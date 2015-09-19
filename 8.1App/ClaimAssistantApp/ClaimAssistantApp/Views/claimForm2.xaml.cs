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
