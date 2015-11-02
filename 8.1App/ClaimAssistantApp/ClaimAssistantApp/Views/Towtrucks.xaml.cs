using ClaimAssistantApp.Common;
using ModelLayer;
using Newtonsoft.Json.Linq;
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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ClaimAssistantApp.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Towtrucks : Page
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


        public Towtrucks()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            GetTowTruckServicesInfo();
        }

        private async void GetTowTruckServicesInfo()
        {
            string location = txtLocation.Text.Trim();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string result = await client.GetTowTruckServiceInfoAsync(location);
            try
            {
                //lstvGarages.Items.Add(new Garage_ML() { GarageName = "a", GarageLocation = "b", GarageTP = "232" });
                JArray v = JArray.Parse(result);
                lstvTowTrucks.ItemsSource = this.GetServiceList(v);

            }
            catch (Exception ex)
            {
                txtLocation.Text = ex.ToString();
            }
        }
        public List<TowTruckService_ML> GetServiceList(JArray v)
        {
            var serviceList = new List<TowTruckService_ML>();
            for (int i = 0; i < v.Count; i++)
            {
                serviceList.Add(new TowTruckService_ML() 
                {
                    name = v[i]["name"].ToString(), 
                    location = v[i]["location"].ToString(), 
                    tp = v[i]["telephone"].ToString() 
                });
            }
            return serviceList;
        }
        private void txtLocation_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetTowTruckServicesInfo();
        }
        private void btnSearchGarage_Click(object sender, RoutedEventArgs e)
        {
            GetTowTruckServicesInfo();

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

        
    }
}
