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
        List<int> SparepartList = new List<int>();
        private double _totalcost = 0;

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public claimForm3()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            loadSparepartCatogoriesToCombo();
            loadSparepartManufacturersToCombo();
        }
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var ml = new Claim_ML
            {
                location = (App.Current as App).location,
                reason = (App.Current as App).reason,
                knockedON = (App.Current as App).knockedOn,
                _3rdVehicleNo = (App.Current as App)._3rdVehicleRegno,
                _3rdOwnerName = (App.Current as App)._3rdOwnerName,
                _3rdAddress = (App.Current as App)._3rdAddress,
                _3rdContactNo = (App.Current as App)._3rdContact,
                _3rdRenewalDate = Convert.ToDateTime((App.Current as App)._3rdRenewalDate),
                _3rdSpecialNotes = (App.Current as App)._3rdSpecialNotes,
                _3rdVictimName = (App.Current as App).victimName,
                _3rdVictimAddress = (App.Current as App).victimAddress,
                _3rdDamageNature = (App.Current as App).damageNature,
                _3rdClaimant = (App.Current as App)._3rdClaimant,
                _3rdAmountClaimed = Convert.ToSingle((App.Current as App)._3rdClaimAmount),
                isDriverOwner = (App.Current as App).isDriverOwner,
                driverName = (App.Current as App).drivername,
                driverLicense = (App.Current as App).driverLicense,
                licenseCat = (App.Current as App).driverCategories,
                licenseExpreDate = Convert.ToDateTime((App.Current as App).driverLicenseExpire),
                driverNIC = (App.Current as App).driverNIC,
                purchaseDate = Convert.ToDateTime((App.Current as App).dateOfPrchase),
                VehicleUsedFor = (App.Current as App).vehicleUsage,
                rentCompanyName = (App.Current as App).rentName,
                rentAmount = Convert.ToSingle((App.Current as App).rentAmount),
                garageCosts = Convert.ToSingle(txtgarageCost.Text),
                otherCosts = Convert.ToSingle(txtgarageCost.Text)
            };

            ml.spareParts = new int[SparepartList.Count];

            for (var i = 0; i < SparepartList.Count; i++)
            {
                ml.spareParts[i] = SparepartList[i];
            }

            //Frame.Navigate(typeof(Views.claimSuccess));
        }

        private void btnAddPart_Click(object sender, RoutedEventArgs e)
        {
            SparepartList.Add(Convert.ToInt32(cmbSparepart.SelectedValue));
            if (cmbSparepart.SelectedItem == null) return;

            var jsonselected = JsonConvert.SerializeObject(cmbSparepart.SelectedItem);
            var obj = JObject.Parse(jsonselected);
            var name = (string)obj["sparepartName"];
            var price = (string)obj["spareUnitCost"];
            lstboxSparelist.Items.Add(name+ "Rs " + price + "/=");
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
            
          cmbSparePartCategory.ItemsSource=GetSparepartCatogories();
        }

        private void loadSparepartManufacturersToCombo(){

            var manufacturerList = GetSparepartManufacturers();        
            cmbSparepartManufacturer.ItemsSource = manufacturerList;
        }

        private void loadSparepartsToCombo(int manufactureId,int categoryId) {
            var list = GetSpareparts();
            var sparepartList = new List<Sparepart_ML>();
            foreach (var item in list)
            {
                if (item.sparepartCategory == categoryId|item.spareManufacturer==manufactureId)
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
            txtgarageCost.Text = catID.ToString();
            loadSparepartsToCombo(ManId,catID);
        }

        private void cmbSparepartManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var catID = Convert.ToInt32(cmbSparePartCategory.SelectedValue);
            var ManId = Convert.ToInt32(cmbSparepartManufacturer.SelectedValue);

            loadSparepartsToCombo(ManId, catID);
        }
    }
}
