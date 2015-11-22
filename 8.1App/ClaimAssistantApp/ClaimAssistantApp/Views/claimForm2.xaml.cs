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


namespace ClaimAssistantApp.Views
{

    public sealed partial class claimForm2 : Page
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


        public claimForm2()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

            tbrentCompny.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            txtRentcarCompany.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            tbAmount.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            txtRentAmount.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
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

        private void btnNextStep3_Click(object sender, RoutedEventArgs e)
        {
            if (rdbYes.IsChecked==true)
            {
                (App.Current as App).isDriverOwner = "Yes";
            }else if(rdbNo.IsChecked==true){
                (App.Current as App).isDriverOwner = "No";
            }
            
            (App.Current as App).drivername = txtDrivername.Text;
            (App.Current as App).driverLicense = txtLicense.Text;
            (App.Current as App).driverCategories = txtCategories.Text;

             DateTimeOffset ex = dpExpireDate.Date;
            (App.Current as App).driverLicenseExpire = ex.Date;

            (App.Current as App).driverNIC = txtNic.Text;
            

            DateTimeOffset pd = dpPurchaseDate.Date;
            (App.Current as App).dateOfPrchase = pd.Date;

             if(cmbVehiclePurpose.SelectedValue != null)
	            {
                    (App.Current as App).vehicleUsage = cmbVehiclePurpose.SelectedValue.ToString();
	            }
                
            //(App.Current as App).rentName = txtRentcarCompany.Text;
            //(App.Current as App).rentAmount = Convert.ToSingle(txtRentAmount.Text);
            
            (App.Current as App).victimName = txtVictimName.Text;
            (App.Current as App).victimAddress = txtVictimAddress.Text;
            (App.Current as App).damageNature = txtdamageNature.Text;

            (App.Current as App)._3rdClaimant = txt3rdPartyClaimant.Text;

            var test = txt3rdAmountClaimed.Text;
            if (txt3rdAmountClaimed.Text != "")
            {
                (App.Current as App)._3rdClaimAmount = Convert.ToSingle(txt3rdAmountClaimed.Text);
            }

            this.Frame.Navigate(typeof(claimForm3));
        }

        private void cmbVehiclePurpose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOption = cmbVehiclePurpose.SelectedValue.ToString();
            if (selectedOption == "Rented")
            {
                tbrentCompny.Visibility = Windows.UI.Xaml.Visibility.Visible;
                txtRentcarCompany.Visibility = Windows.UI.Xaml.Visibility.Visible;
                tbAmount.Visibility = Windows.UI.Xaml.Visibility.Visible;
                txtRentAmount.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                tbrentCompny.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                txtRentcarCompany.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                tbAmount.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                txtRentAmount.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }
    }
}
