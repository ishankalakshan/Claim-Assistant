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
using Windows.Security.Cryptography;
using Windows.Storage.Streams;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ClaimAssistantApp
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        bool networkError = false;

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
               Frame.Navigate(typeof(Views.MainMenu));    
            /*try
            {
                
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                var res = await client.AuthenticateAsync(txtUsername.Text, txtPassword.Password); 
                if (res!="")
	                {
                       (App.Current as App).empid = res.Split(',')[0];
                       (App.Current as App).empName = res.Split(',')[2];
                        var type = res.Split(',')[1];
                        if (type=="agent")
                        {
                            Frame.Navigate(typeof(Views.MainMenu));
                        }
                        else
                        {
                            var messageDialog = new Windows.UI.Popups.MessageDialog("You dont have permissons to login");
                            messageDialog.Title = "Access Denied";
                            await messageDialog.ShowAsync();
                        }
		                
                    }
                else
                {
                   var messageDialog = new Windows.UI.Popups.MessageDialog("Username or Password entered is invalid");
                   messageDialog.Title = "Access Denied";
                   await messageDialog.ShowAsync();
                }
            }
            catch(System.ServiceModel.EndpointNotFoundException ex2){
                networkError = true;
                }             
            catch (Exception ex)
            {
               
                txtUsername.Text = ex.ToString();
            }
            if (networkError)
	        {
		     var NetworkErrorMessage = new Windows.UI.Popups.MessageDialog("Could not connect to the network");
                      NetworkErrorMessage.Title = "Network Error";
                      await NetworkErrorMessage.ShowAsync();
	        }*/
        }
    }
}
