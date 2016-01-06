using System;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Windows.System;
using Newtonsoft.Json;



namespace Final.Year.Mobile.sln
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            tbDate.Text = (DateTime.Today).ToString("MM/dd/yyyy");
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtPolicyId.Text==null||txtPolicyId.Text=="")
            {
                var dialog = new MessageDialog("Enter your policy number");
                await dialog.ShowAsync();
                return;
            }
            progressring.IsActive = true;
            progressring.Height = Window.Current.Bounds.Height;
            progressring.Width = Window.Current.Bounds.Width;
            var locationAccessDenied = false;
            var geolocator = new Geolocator { DesiredAccuracyInMeters = 50 };
           
            //var dialog = new MessageDialog(result);
            //await dialog.ShowAsync();
            //string result = await WCFRESTServiceCall("POST", "PostMessage", "\"Nguyen Thanh Tung\"");
            //var dialog = new MessageDialog(result);
            //await dialog.ShowAsync();

            try
            {
                var geoposition = await geolocator.GetGeopositionAsync(
                     maximumAge: TimeSpan.FromMinutes(5),
                     timeout: TimeSpan.FromSeconds(10)
                );

                //geolocation.Text = "GPS:" + geoposition.Coordinate.Latitude.ToString("0.00") + ", " + geoposition.Coordinate.Longitude.ToString("0.00");
                var  claimrequest = new ClaimRequest_ML()
                {
                    PolicyId=Convert.ToInt32(txtPolicyId.Text),
                    Latitude = geoposition.Coordinate.Latitude.ToString("0.00"),
                    Longitude = geoposition.Coordinate.Longitude.ToString("0.00"),
                    Status = "Pending"
                };
                var jClaimRequest = JsonConvert.SerializeObject(claimrequest);
                string result = await WCFRESTServiceCall("POST", "AddClaimRequest", jClaimRequest);
                //string result = await WCFRESTServiceCall("GET", "AddClaimRequest");
                if (result=="")
                {
                    progressring.IsActive = false;
                    var dialog = new MessageDialog("Network error occured.");
                    await dialog.ShowAsync();
                }
                else if (result=="0")
                {
                    progressring.IsActive = false;
                    var dialog = new MessageDialog("Reported Succussfuly.");
                    await dialog.ShowAsync();
                }
                else if (result=="1")
                {
                    progressring.IsActive = false;
                    var dialog = new MessageDialog("Invalid policy number.");
                    await dialog.ShowAsync();
                }
                else
                {
                    progressring.IsActive = false;
                    var dialog = new MessageDialog("Error occured.");
                    await dialog.ShowAsync();
                }
                
            }
            catch (Exception ex)
            {
                //throw ex;
                progressring.IsActive = false;
               locationAccessDenied = true;
            }
            if (locationAccessDenied)
            {
                progressring.IsActive = false;
                var dialog = new MessageDialog("Turn on location");
                await dialog.ShowAsync();
                //await Launcher.LaunchUriAsync(new Uri("ms-settings-location:"));
            }

        }

        private async Task<string> WCFRESTServiceCall(string methodRequestType, string methodName, string bodyParam = "")
        {
            try
            {
                string ServiceURI = "http://localhost:8733/Design_Time_Addresses/Rest_Service/Service1/rest/" + methodName;
                HttpClient httpClient = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(methodRequestType == "GET" ? HttpMethod.Get : HttpMethod.Post, ServiceURI);
                if (!string.IsNullOrEmpty(bodyParam))
                {
                    request.Content = new StringContent(bodyParam, Encoding.UTF8);
                }
                HttpResponseMessage response = await httpClient.SendAsync(request);
                string returnString = await response.Content.ReadAsStringAsync();
                return returnString;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

    }
}
