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
    public sealed partial class claimInformation : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        public bool IsPolicyNoEntered = false;

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

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
            IsPolicyNoEntered = false;
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

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

        private async void btnPolicynoSubmit_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
            if (txtPolicyNumber.Text == "" || txtPolicyNumber.Text == null)
            {
                var NetworkErrorMessage = new Windows.UI.Popups.MessageDialog("Please enter policy number");
                NetworkErrorMessage.Title = "Error";
                await NetworkErrorMessage.ShowAsync();
                return;
            }
            GetAndFillPolicyData();
            GetAndFillClaimHistory();
        }

        private async void GetAndFillPolicyData()
        {
            try
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                var result = await client.GetPolicyInfoAsync(Convert.ToInt16(txtPolicyNumber.Text));
                if (result != "[]")
                {
                    JArray policyInformation = JArray.Parse(result);

                    tbInsuredPerson.Text = policyInformation[0]["Name"].ToString();
                    tbAddress.Text = policyInformation[0]["Address"].ToString();
                    tbNic.Text = policyInformation[0]["NIC"].ToString();
                    tbPhoneNo.Text = policyInformation[0]["Mobile"].ToString();
                    tbEmail.Text = policyInformation[0]["Email"].ToString();

                    tbRegistrationNo.Text = policyInformation[0]["RegistrationNo"].ToString();
                    tbColor.Text = policyInformation[0]["Color"].ToString();
                    tbEngineNo.Text =policyInformation[0]["EngineNo"].ToString();
                    tbChassissNo.Text = policyInformation[0]["ChassisNo"].ToString();
                    tbManufacturer.Text = policyInformation[0]["ManufactureName"].ToString();

                    tbModel.Text = policyInformation[0]["Model"].ToString();
                    tbYear.Text = policyInformation[0]["MakeYear"].ToString();
                    tbEngineCapacity.Text = policyInformation[0]["EngineCpacity"].ToString();
                    tbAbsoluteOwner.Text = policyInformation[0]["AbsoluteOwner"].ToString();
                    tbFinancialRights.Text =  policyInformation[0]["FinancialRights"].ToString();

                    tbUsage.Text = policyInformation[0]["Usage"].ToString();
                    tbCurrentDamages.Text = policyInformation[0]["CurrentDamages"].ToString();
                    tbExtraFitting.Text = policyInformation[0]["ExtraFittins"].ToString();
                    tbPresentValue.Text = policyInformation[0]["PresentValue"].ToString();

                    tbPolicyId.Text = tbPolicyId.Text + " " + "4";
                    tbExpireOn.Text = tbExpireOn.Text + " " + policyInformation[0]["ExpireOn"].ToString();
                    tbCommenceOn.Text = tbCommenceOn.Text + " " + policyInformation[0]["commenceOn"].ToString();
                    tbNaturalDisaster.Text = tbNaturalDisaster.Text + " " + policyInformation[0]["natural_disaster"].ToString();
                    tbPassengerCompensastion.Text = tbPassengerCompensastion.Text + " " + policyInformation[0]["passenger_compensation"].ToString();

                    tbDriverCompensastion.Text = tbDriverCompensastion.Text + " " + policyInformation[0]["driver_compensation"].ToString();
                    tbTowingCharges.Text = tbTowingCharges.Text + " " + policyInformation[0]["towing_charges"].ToString();
                    tbTerrorCover.Text = tbTerrorCover.Text + " " + policyInformation[0]["tercover"].ToString();
                    tbVandalism.Text = tbVandalism.Text + " " + policyInformation[0]["vandalism"].ToString();

                    IsPolicyNoEntered = true;
                }
                else
                {

                    var NetworkErrorMessage = new Windows.UI.Popups.MessageDialog("Invalid policy number");
                    NetworkErrorMessage.Title = "Error";
                    await NetworkErrorMessage.ShowAsync();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void GetAndFillClaimHistory()
        {
            try
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                var history = await client.GetClaimHistoryAsync(Convert.ToInt16(txtPolicyNumber.Text));

                if (history != "[]")
                {
                    var claimHistory = JArray.Parse(history);
                    foreach (var item in claimHistory)
                    {
                        stackHistory.Children.Add(
                            new TextBlock() { Text = item["createdtime"].ToString(), FontSize = 15 });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Views.MainMenu));
        }

        private async void btnClaim_Click(object sender, RoutedEventArgs e)
        {
            if (IsPolicyNoEntered)//
            {
                (App.Current as App).policyid = txtPolicyNumber.Text;
                Frame.Navigate(typeof(Views.claimForm1));
            }
            else
            {
                var NetworkErrorMessage = new Windows.UI.Popups.MessageDialog("Enter a policy number first");
                NetworkErrorMessage.Title = "Error";
                await NetworkErrorMessage.ShowAsync();
                return;   
            }      
        }

        private void ClearAll()
        {
            tbInsuredPerson.Text = "";
            tbAddress.Text = "";
            tbNic.Text = "";
            tbPhoneNo.Text = "";
            tbEmail.Text = "";

            tbRegistrationNo.Text = "";
            tbColor.Text = "";
            tbEngineNo.Text = "";
            tbChassissNo.Text = "";
            tbManufacturer.Text = "";

            tbModel.Text = "";
            tbYear.Text = "";
            tbEngineCapacity.Text = "";
            tbAbsoluteOwner.Text = "";
            tbFinancialRights.Text = "";

            tbUsage.Text = "";
            tbCurrentDamages.Text = "";
            tbExtraFitting.Text = "";
            tbPresentValue.Text = "";

            tbPolicyId.Text = "";
            tbExpireOn.Text = "";
            tbCommenceOn.Text = "";
            tbNaturalDisaster.Text = "";
            tbPassengerCompensastion.Text = "";

            tbDriverCompensastion.Text = "";
            tbTowingCharges.Text = "";
            tbTerrorCover.Text = "";
            tbVandalism.Text = "";

            stackHistory.Children.Clear();

            IsPolicyNoEntered = false;
        }
    }
}
