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
using Windows.Data.Json;
using Newtonsoft.Json.Linq;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ClaimAssistantApp.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class claimInformation : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        public bool isNotEnteredPolicynumber = false;

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public claimInformation()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void btnPolicynoSubmit_Click(object sender, RoutedEventArgs e)
        {

            getAndFillPolicyData();
        }

        private async void getAndFillPolicyData() {
            try
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                var result = await client.GetPolicyInfoAsync(Convert.ToInt16(txtPolicyNumber.Text));
                JArray policyInformation = JArray.Parse(result);
               
                tbInsuredPerson.Text = tbInsuredPerson.Text + " " + policyInformation[0]["Name"].ToString();
                tbAddress.Text = tbAddress.Text + " " + policyInformation[0]["Address"].ToString();
                tbNic.Text = tbNic.Text + " " + policyInformation[0]["NIC"].ToString();
                tbPhoneNo.Text = tbPhoneNo.Text + " " + policyInformation[0]["Mobile"].ToString();
                tbEmail.Text = tbEmail.Text + " " + policyInformation[0]["Email"].ToString();

                tbRegistrationNo.Text = tbRegistrationNo.Text + " " + policyInformation[0]["RegistrationNo"].ToString();
                tbColor.Text = tbColor.Text + " " + policyInformation[0]["Color"].ToString();
                tbEngineNo.Text = tbEngineNo.Text + " " + policyInformation[0]["EngineNo"].ToString();
                tbChassissNo.Text = tbChassissNo.Text + " " + policyInformation[0]["ChassisNo"].ToString();
                tbManufacturer.Text = tbManufacturer.Text + " " + policyInformation[0]["ManufactureName"].ToString();

                tbModel.Text = tbModel.Text + " " + policyInformation[0]["Model"].ToString();
                tbYear.Text = tbYear.Text + " " + policyInformation[0]["MakeYear"].ToString();
                tbEngineCapacity.Text = tbEngineCapacity.Text + " " + policyInformation[0]["EngineCpacity"].ToString();
                tbAbsoluteOwner.Text = tbAbsoluteOwner.Text + " " + policyInformation[0]["AbsoluteOwner"].ToString();
                tbFinancialRights.Text = tbFinancialRights.Text + " " + policyInformation[0]["FinancialRights"].ToString();

                tbUsage.Text = tbUsage.Text + " " + policyInformation[0]["Usage"].ToString();
                tbCurrentDamages.Text = tbCurrentDamages.Text + " " + policyInformation[0]["CurrentDamages"].ToString();
                tbExtraFitting.Text = tbExtraFitting.Text + " " + policyInformation[0]["ExtraFittins"].ToString();
                tbPresentValue.Text = tbPresentValue.Text + " " + policyInformation[0]["PresentValue"].ToString();

                tbPolicyId.Text = tbPolicyId.Text + " " + "4";
                tbExpireOn.Text = tbExpireOn.Text + " " + policyInformation[0]["ExpireOn"].ToString();
                tbCommenceOn.Text = tbCommenceOn.Text + " " + policyInformation[0]["commenceOn"].ToString();
                tbNaturalDisaster.Text = tbNaturalDisaster.Text + " " + policyInformation[0]["natural_disaster"].ToString();
                tbPassengerCompensastion.Text = tbPassengerCompensastion.Text + " " + policyInformation[0]["passenger_compensation"].ToString();

                tbDriverCompensastion.Text = tbDriverCompensastion.Text + " " + policyInformation[0]["driver_compensation"].ToString();
                tbTowingCharges.Text = tbTowingCharges.Text + " " + policyInformation[0]["towing_charges"].ToString();
                tbTerrorCover.Text = tbTerrorCover.Text + " " + policyInformation[0]["tercover"].ToString();
                tbVandalism.Text = tbVandalism.Text + " " + policyInformation[0]["vandalism"].ToString();
               
            }catch(System.FormatException){
                isNotEnteredPolicynumber = true;
            }
            catch (Exception)
            {

                throw;
            }

            if (isNotEnteredPolicynumber)
            {
                var NetworkErrorMessage = new Windows.UI.Popups.MessageDialog("Please enter policy number");
                NetworkErrorMessage.Title = "Error";
                await NetworkErrorMessage.ShowAsync();
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Views.MainMenu));
        }

        private void btnClaim_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Views.claimForm1));
        }
    }
}
