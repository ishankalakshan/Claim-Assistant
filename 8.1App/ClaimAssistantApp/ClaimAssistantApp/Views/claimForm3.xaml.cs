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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var ml = new Claim_ML(
                4,
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
                txtgarageCost.Text
                );
            var result = JsonConvert.SerializeObject(ml);
            var data = new ServiceReference1.Service1Client().InsertClaimAsync(result);

            //Frame.Navigate(typeof(Views.claimSuccess));
        }

        private void btnAddPart_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSparepart.SelectedItem == null) return;

            var jsonselected = JsonConvert.SerializeObject(cmbSparepart.SelectedItem);
            var obj = JObject.Parse(jsonselected);
            var name = (string)obj["sparepartName"];
            var price = (string)obj["spareUnitCost"];
            lstboxSparelist.Items.Add(name + "Rs " + price + "/=" + "Qty: "+txtQuantity.Text);

            SparepartList.Add(new SparepartPayment_ML() 
            { 
                SparepartId= Convert.ToInt32(cmbSparepart.SelectedValue),
                SparepartQty = Convert.ToDouble(txtQuantity.Text),
                SparepartCost = Convert.ToDouble(price)
            });   
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstboxSparelist.SelectedValue;
            lstboxSparelist.Items.Remove(selected);
        }

        private List<SparepartCategory_ML> GetSparepartCatogories()
        {
            var spareList = new List<SparepartCategory_ML>();
            spareList.Add(new SparepartCategory_ML() { spareId=1, spareCatergory="Lamps"});
            spareList.Add(new SparepartCategory_ML() { spareId = 2, spareCatergory = "Tires" });
            spareList.Add(new SparepartCategory_ML() { spareId = 3, spareCatergory = "Mirrors" });

            return spareList;
        }

        private List<SparepartManufacturer_ML> GetSparepartManufacturers()
        {
            var spareManufacturerList = new List<SparepartManufacturer_ML>();
            spareManufacturerList.Add(new SparepartManufacturer_ML() { manufacturerId=1, manufacturerName="Toyota"});
            spareManufacturerList.Add(new SparepartManufacturer_ML() { manufacturerId = 2, manufacturerName = "DSI" });

            return spareManufacturerList;
        }

        private List<Sparepart_ML> GetSpareparts()
        {
            var sparepartList = new List<Sparepart_ML>();
            sparepartList.Add(new Sparepart_ML() {sparepartId=1,sparepartName="Xenon Head Lamps", sparepartCategory=1,spareManufacturer=1,spareManufacYear="2015",spareUnitCost=25000.00f});
            sparepartList.Add(new Sparepart_ML() { sparepartId = 2, sparepartName = "Side Mirror", sparepartCategory = 3, spareManufacturer = 1, spareManufacYear = "2015", spareUnitCost = 25000.00f });
            sparepartList.Add(new Sparepart_ML() { sparepartId = 3, sparepartName = "23' Tire", sparepartCategory = 2, spareManufacturer = 2, spareManufacYear = "2015", spareUnitCost = 24500.00f });

            return sparepartList;
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
            cmbSparepart.ItemsSource = sparepartList;
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
