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
    public sealed partial class claimForm1 : Page
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


        public claimForm1()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
      
            txtReason.IsEnabled = false;
            txtKnockedOn.IsEnabled = false;
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

        private void btnNextStep2_Click(object sender, RoutedEventArgs e)
        {
            /*if (txtLocation.Text=="")
            {
                showMessageBox("Location required");
                return;
            }
            if (txtReason.Text == "")
            {
                showMessageBox("Reason required");
                return;
            }
            if (txtKnockedOn.Text == "")
            {
                showMessageBox("Knocked On required");
                return;
            }
            if (txt3rdVehicleNo.Text == "")
            {
                showMessageBox("3rd party vehicle number required.");
                return;
            }
            if (txt3rdOwnerName.Text == "")
            {
                showMessageBox("Owner name required");
                return;
            }*/

            (App.Current as App).location = txtLocation.Text;
            (App.Current as App).reason = txtReason.Text;
            (App.Current as App).knockedOn = txtKnockedOn.Text;
            (App.Current as App)._3rdVehicleRegno = txt3rdVehicleNo.Text;
            (App.Current as App)._3rdOwnerName = txt3rdOwnerName.Text;
            (App.Current as App)._3rdAddress = txt3rdAddress.Text;
            (App.Current as App)._3rdContact = txt3rdContactno.Text;

            DateTimeOffset st = txt3rdRenewalDate.Date;
            (App.Current as App)._3rdRenewalDate = st.Date;

            (App.Current as App)._3rdSpecialNotes = txtNotes.Text;
            this.Frame.Navigate(typeof(claimForm2));
        }

        public async void showMessageBox(string error) {
            var messageDialog = new Windows.UI.Popups.MessageDialog(error);
            messageDialog.Title = "Fill the form";
            await messageDialog.ShowAsync();
        }

        private void cmbReason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOption = cmbReason.SelectedValue.ToString();
            txtReason.Text = selectedOption;
            if (selectedOption=="Other")
            {
                txtReason.IsEnabled = true;
            }
            else
            {
                txtReason.IsEnabled = false;
            }
        }

        private void cmbKnockedOn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOption = cmbKnockedOn.SelectedValue.ToString();
            txtKnockedOn.Text = selectedOption;
            if (selectedOption == "Other")
            {
                txtKnockedOn.IsEnabled = true;
            }
            else
            {
                txtKnockedOn.IsEnabled = false;
            }
        }
    }
}
