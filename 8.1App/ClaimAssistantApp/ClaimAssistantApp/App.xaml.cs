using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace ClaimAssistantApp
{
    sealed partial class App : Application
    {

        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        public string location { get; set; }
        public string reason { get; set; }
        public string knockedOn { get; set; }
        public string _3rdVehicleRegno { get; set; }
        public string _3rdOwnerName { get; set; }
        public string _3rdAddress { get; set; }
        public string _3rdContact { get; set; }
        public DateTime _3rdRenewalDate { get; set; }
        public string _3rdSpecialNotes { get; set; }

        public string isDriverOwner { get; set; }
        public string drivername { get; set; }
        public string driverLicense { get; set; }
        public string driverCategories { get; set; }
        public DateTime driverLicenseExpire { get; set; }
        public string driverNIC { get; set; }
        public DateTime dateOfPrchase { get; set; }
        public string vehicleUsage { get; set; }
        public string rentName { get; set; }
        public float rentAmount { get; set; }
        public string victimName { get; set; }
        public string victimAddress { get; set; }
        public string damageNature { get; set; }
        public string _3rdClaimant { get; set; }
        public float _3rdClaimAmount { get; set; }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {

                rootFrame = new Frame();

                rootFrame.Language = Windows.Globalization.ApplicationLanguages.Languages[0];

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                   
                }


                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {

                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }

            Window.Current.Activate();
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
