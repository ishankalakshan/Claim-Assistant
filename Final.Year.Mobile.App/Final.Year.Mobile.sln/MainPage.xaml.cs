using System;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;  



namespace Final.Year.Mobile.sln
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }


        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var geolocator = new Geolocator {DesiredAccuracyInMeters = 50};

            try
            {
                MessageDialog msgbox = new MessageDialog("Reported Successfully");
                await msgbox.ShowAsync();  
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
