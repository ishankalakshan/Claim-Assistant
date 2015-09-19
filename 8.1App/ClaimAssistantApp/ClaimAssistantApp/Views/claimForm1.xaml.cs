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
            this.Frame.Navigate(typeof(claimForm2));
        }

        private void cmbReason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOption = cmbReason.SelectedValue.ToString();
            if (selectedOption=="Other")
            {
                txtReason.IsEnabled = true;
            }
            else
            {
                txtReason.Text = "";
                txtReason.IsEnabled = false;
            }
        }

        private void cmbKnockedOn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOption = cmbKnockedOn.SelectedValue.ToString();
            if (selectedOption == "Other")
            {
                txtKnockedOn.IsEnabled = true;
            }
            else
            {
                txtKnockedOn.Text = "";
                txtKnockedOn.IsEnabled = false;
            }
        }
    }
}
