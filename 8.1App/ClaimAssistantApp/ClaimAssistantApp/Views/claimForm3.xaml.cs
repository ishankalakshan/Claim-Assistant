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
using ModelLayer;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ClaimAssistantApp.Views
{
    public sealed partial class claimForm3 : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
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
            Claim_ML ml = new Claim_ML();
            ml.location = (App.Current as App).location;
            ml.reason = (App.Current as App).reason;
            ml.knockedON = (App.Current as App).knockedOn;
            ml._3rdVehicleNo = (App.Current as App)._3rdVehicleRegno;
            ml._3rdOwnerName = (App.Current as App)._3rdOwnerName;
            ml._3rdAddress = (App.Current as App)._3rdAddress;
            ml._3rdContactNo = (App.Current as App)._3rdContact;
            ml._3rdRenewalDate = (App.Current as App)._3rdRenewalDate;
            ml._3rdSpecialNotes = (App.Current as App)._3rdSpecialNotes;
            ml._3rdVictimName = (App.Current as App).victimName;
            ml._3rdVictimAddress = (App.Current as App).victimAddress;
            ml._3rdDamageNature = (App.Current as App).damageNature;
            ml._3rdClaimant = (App.Current as App)._3rdClaimant;
            ml._3rdAmountClaimed = (App.Current as App)._3rdClaimAmount;
            ml.isDriverOwner = (App.Current as App).isDriverOwner;
            ml.driverName = (App.Current as App).drivername;
            ml.driverLicense = (App.Current as App).driverLicense;
            ml.licenseCat = (App.Current as App).driverCategories;
            ml.licenseExpreDate = (App.Current as App).driverLicenseExpire;
            ml.driverNIC = (App.Current as App).driverNIC;
            ml.purchaseDate = (App.Current as App).dateOfPrchase;
            ml.VehicleUsedFor = (App.Current as App).vehicleUsage;
            ml.rentCompanyName = (App.Current as App).rentName;
            ml.rentAmount = (App.Current as App).rentAmount;

            ml.garageCosts = Convert.ToSingle(txtgarageCost.Text);
            ml.otherCosts = Convert.ToSingle(txtgarageCost.Text);
            txtgarageCost.Text = ml.location;
            //Frame.Navigate(typeof(Views.claimSuccess));
        }

        private void btnAddPart_Click(object sender, RoutedEventArgs e)
        {
            lstboxSparelist.Items.Add("Rear Buffor");
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstboxSparelist.SelectedValue;
            lstboxSparelist.Items.Remove(selected);
        }

        private List<SparepartCategory_ML> GetSparepartCatogories()
        {
             List<SparepartCategory_ML> spareList = new List<SparepartCategory_ML>();
            spareList.Add(new SparepartCategory_ML() { spareId=1, spareCatergory="Lamps"});
            spareList.Add(new SparepartCategory_ML() { spareId = 2, spareCatergory = "Tires" });
            spareList.Add(new SparepartCategory_ML() { spareId = 3, spareCatergory = "Mirrors" });

            return spareList;
        }

        private List<Sparepart_ML> GetSpareparts()
        {
            List<Sparepart_ML> sparepartList = new List<Sparepart_ML>();
            sparepartList.Add(new Sparepart_ML() {sparepartId=1,sparepartName="Xenon Head Lamps", sparepartCategory=1,spareManufacturer="Toyota",spareManufacYear="2015",spareUnitCost=25000});
            sparepartList.Add(new Sparepart_ML() { sparepartId = 2, sparepartName = "Side Mirror", sparepartCategory = 3, spareManufacturer = "Toyota", spareManufacYear = "2015", spareUnitCost = 25000 });
            sparepartList.Add(new Sparepart_ML() { sparepartId = 3, sparepartName = "23' Tire", sparepartCategory = 2, spareManufacturer = "DSI", spareManufacYear = "2015", spareUnitCost = 25000 });

            return sparepartList;
        }

        private void loadSparepartCatogoriesToCombo() {
            
          cmbSparePartCategory.ItemsSource=GetSparepartCatogories();
        }

        private void loadSparepartManufacturersToCombo(int manufacturerId){

            List<SparepartManufacturer_ML> list = GetSparepartManufacturers();
            List<SparepartManufacturer_ML> manufacturerList = new List<SparepartManufacturer_ML>();
            foreach (var item in list)
            {
                if (item.manufacturerId==manufacturerId)
                {
                    manufacturerList.Add(item);
                }
                
            }
            cmbSparepartManufacturer.ItemsSource = manufacturerList;
        }

        private void cmbSparePartCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSparecost.Text = cmbSparePartCategory.SelectedValue.ToString();
            loadSparepartManufacturersToCombo(Convert.ToInt32(txtSparecost.Text));
        }
    }
}
