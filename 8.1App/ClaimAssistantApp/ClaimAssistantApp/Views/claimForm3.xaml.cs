using ClaimAssistantApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.AtomPub;
using ModelLayer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ClaimAssistantApp.Views
{
    public sealed partial class claimForm3 : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        List<SparepartPayment_ML> SparepartList = new List<SparepartPayment_ML>();
        private double _totalcost = 0;
        List<SparepartCategory_ML> LocalSparepartCatogoryList = new List<SparepartCategory_ML>();
        List<SparepartManufacturer_ML> LocalSparepartmanufacturerList = new List<SparepartManufacturer_ML>();
        List<Sparepart_ML> LocalSparepartsList = new List<Sparepart_ML>();

        public claimForm3()
        {
            
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            LoadSparepartCategories();
            LoadSparepartManufacturers();
            LoadSpareparts();

            loadSparepartCatogoriesToCombo();
            loadSparepartManufacturersToCombo();
            
        }

        public async void LoadSparepartCategories()
        {            
            try
            {
                var client = new ServiceReference1.Service1Client();
                var result = await client.GetSparepartCategoriesAsync();
                var sprepartCategories = JArray.Parse(result);

                foreach (var item in sprepartCategories)
                {
                    LocalSparepartCatogoryList.Add(new SparepartCategory_ML(item));
                }
            }
            catch (Exception)
            {
                
                throw;
            }           
        }

        public async void LoadSparepartManufacturers()
        {
            try
            {
                var client = new ServiceReference1.Service1Client();
                var result = await client.GetSparepartManufacturersAsync();
                var sprepartManufacturers = JArray.Parse(result);

                foreach (var item in sprepartManufacturers)
                {
                    LocalSparepartmanufacturerList.Add(new SparepartManufacturer_ML(item));                
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void LoadSpareparts()
        {
            try
            {
                var client = new ServiceReference1.Service1Client();
                var result = await client.GetSparepartsAsync();
                var spareparts = JArray.Parse(result);

                foreach (var item in spareparts)
                {
                    LocalSparepartsList.Add(new Sparepart_ML(item));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
           var ml = new Claim_ML(
                (App.Current as App).policyid,
                (App.Current as App).location,
                (App.Current as App).reason,
                (App.Current as App).knockedOn,
                (App.Current as App)._3rdVehicleRegno,
                (App.Current as App)._3rdOwnerName,
                (App.Current as App)._3rdAddress,
                (App.Current as App)._3rdContact,
                (App.Current as App)._3rdRenewalDate,
                (App.Current as App)._3rdSpecialNotes,
                (App.Current as App).victimName,
                (App.Current as App).victimAddress,
                (App.Current as App).damageNature,
                (App.Current as App)._3rdClaimant,
                (App.Current as App)._3rdClaimAmount,
                (App.Current as App).isDriverOwner,
                (App.Current as App).drivername,
                (App.Current as App).driverLicense,
                (App.Current as App).driverCategories,
                (App.Current as App).driverLicenseExpire,
                (App.Current as App).driverNIC,
                (App.Current as App).dateOfPrchase,
                (App.Current as App).vehicleUsage,
                (App.Current as App).rentName,
                (App.Current as App).rentAmount,
                SparepartList,
                txtgarageCost.Text,
                txtgarageCost.Text,
                (App.Current as App).empid
                );
            var result = JsonConvert.SerializeObject(ml);
            var data =  await new ServiceReference1.Service1Client().InsertClaimAsync(result);
            if (data)
            {
                Frame.Navigate(typeof(Views.claimSuccess));
            }           
        }

        private async void btnAddPart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtQuantity.Text=="")
                {
                    var messageDialog = new Windows.UI.Popups.MessageDialog("Enter quantity");
                    messageDialog.Title = "Required";
                    await messageDialog.ShowAsync();
                    return;
                }

                if (cmbSparepart.SelectedItem == null) return;

                var jsonselected = JsonConvert.SerializeObject(cmbSparepart.SelectedItem);
                var obj = JObject.Parse(jsonselected);
                var name = (string)obj["sparepartName"];
                var price = (string)obj["spareUnitCost"];
                lstboxSparelist.Items.Add(name + "-" + " Rs " + price + "/=  " + "  Qty: " + txtQuantity.Text);

                _totalcost += Convert.ToSingle(price) * Convert.ToInt32(txtQuantity.Text);

                SparepartList.Add(new SparepartPayment_ML()
                {
                    SparepartId = Convert.ToInt32(cmbSparepart.SelectedValue),
                    SparepartQty = Convert.ToDouble(txtQuantity.Text),
                    SparepartCost = Convert.ToDouble(price)
                });   
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstboxSparelist.SelectedValue;
            var name = selected.ToString().Split('-')[0];
            lstboxSparelist.Items.Remove(selected);
        }

        private void loadSparepartCatogoriesToCombo() {

            cmbSparePartCategory.ItemsSource = LocalSparepartCatogoryList;
        }

        private void loadSparepartManufacturersToCombo(){
            cmbSparepartManufacturer.ItemsSource = LocalSparepartmanufacturerList;
        }

        private void loadSparepartsToCombo(int categoryId, int manufacturerId)
        {
            var list = LocalSparepartsList;
            var sparepartList = new List<Sparepart_ML>();
            foreach (var item in list)
            {
                if (item.sparepartCategory == categoryId || item.spareManufacturer==manufacturerId)
                {
                    sparepartList.Add(item);
                }

            }
            cmbSparepart.ItemsSource = list;
        }

        private void cmbSparePartCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var catID = Convert.ToInt32(cmbSparePartCategory.SelectedValue); 
            var ManId = Convert.ToInt32(cmbSparepartManufacturer.SelectedValue);
            loadSparepartsToCombo(catID,ManId);
        }

        private void cmbSparepartManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var catID = Convert.ToInt32(cmbSparePartCategory.SelectedValue);
            var ManId = Convert.ToInt32(cmbSparepartManufacturer.SelectedValue);
            loadSparepartsToCombo(catID,ManId);
        }



        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        #region NavigationHelper registration

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
    }
}
