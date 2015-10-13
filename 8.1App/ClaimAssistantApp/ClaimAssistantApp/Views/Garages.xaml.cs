using ClaimAssistantApp.Common;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ModelLayer;
using Newtonsoft.Json.Linq;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ClaimAssistantApp.Views

{
    public sealed partial class Garages : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        public List<Garage_ML> people;

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


        public Garages()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            GetGarageinfo();
        }
        private async void GetGarageinfo()
        {
            string location = txtLocation.Text.Trim();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string result = await client.GetGarageInfoAsync(location);
            try
            {
                //lstvGarages.Items.Add(new Garage_ML() { GarageName = "a", GarageLocation = "b", GarageTP = "232" });
                JArray v = JArray.Parse(result);
                lstvGarages.ItemsSource = this.GetGarageList(v);
                
            }
            catch (Exception ex)
            {
                txtLocation.Text = ex.ToString();
            }
        }
        public List<Garage_ML> GetGarageList(JArray v)
        {
            List<Garage_ML> garageList = new List<Garage_ML>();           
            for (int i=0; i<v.Count ;i++ )
            {
                garageList.Add(new Garage_ML() { GarageName = v[i]["GarageName"].ToString(), GarageLocation = v[i]["GarageLocation"].ToString(), GarageTP = v[i]["GarageTP"].ToString() });
            }
            return garageList;
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

        private void btnSearchGarage_Click(object sender, RoutedEventArgs e)
        {
            GetGarageinfo();
            
        }

        private void txtLocation_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetGarageinfo();
        }
        
    }
}
