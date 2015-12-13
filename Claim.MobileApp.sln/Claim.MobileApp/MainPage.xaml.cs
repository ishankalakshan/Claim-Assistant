using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Claim.MobileApp.Resources;
using Windows.Devices.Geolocation;

namespace Claim.MobileApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var geolocator = new Geolocator { DesiredAccuracyInMeters = 50 };
            try
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();        
                //MessageDialog msgbox = new MessageDialog("Reported Successfully");
                //await msgbox.ShowAsync();  
                /*var geoposition = await geolocator.GetGeopositionAsync(
                     maximumAge: TimeSpan.FromMinutes(5),
                     timeout: TimeSpan.FromSeconds(10)
                );
       
                geolocation.Text = "GPS:" + geoposition.Coordinate.Latitude.ToString("0.00") + ", " + geoposition.Coordinate.Longitude.ToString("0.00");*/

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}