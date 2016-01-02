﻿using ClaimAssistantApp.Common;
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
using Windows.Web.AtomPub;
using ModelLayer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Windows.Storage.Pickers;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClaimAssistantApp.ServiceReference1;
// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ClaimAssistantApp.Views
{
    public sealed partial class claimForm3 : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        List<SparepartPayment_ML> SparepartList = new List<SparepartPayment_ML>();
        private double _totalcost = 0;
        List<SparepartCategory_ML> LocalSparepartCatogoryList = new List<SparepartCategory_ML>();
        List<SparepartManufacturer_ML> LocalSparepartmanufacturerList = new List<SparepartManufacturer_ML>();
        List<Sparepart_ML> LocalSparepartsList = new List<Sparepart_ML>();
        IReadOnlyList<StorageFile> fileList = null;

        private Service1Client _client = new Service1Client();

        public claimForm3()
        {

            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            LoadSparepartCategories();
            LoadSparepartManufacturers();
            LoadSpareparts("", "");

            loadSparepartCatogoriesToCombo();
            loadSparepartManufacturersToCombo();
            loadSparepartsToCombo();

        }

        public async void LoadSparepartCategories()
        {
            try
            {
                var client = new ServiceReference1.Service1Client();
                var result = await client.GetSparepartCategoriesAsync();
                var sprepartCategories = JArray.Parse(result);

                foreach (var item in sprepartCategories)
                {
                    LocalSparepartCatogoryList.Add(new SparepartCategory_ML(item));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void LoadSparepartManufacturers()
        {
            try
            {
                var client = new ServiceReference1.Service1Client();
                var result = await client.GetSparepartManufacturersAsync();
                var sprepartManufacturers = JArray.Parse(result);

                foreach (var item in sprepartManufacturers)
                {
                    LocalSparepartmanufacturerList.Add(new SparepartManufacturer_ML(item));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void LoadSpareparts(string manufacturer, string catergory)
        {
            try
            {
                LocalSparepartsList.Clear();
                var client = new ServiceReference1.Service1Client();
                var result = await client.GetSparepartsAsync(manufacturer, catergory);
                var spareparts = JArray.Parse(result);
                var sparelist = new List<Sparepart_ML>();

                foreach (var item in spareparts)
                {
                    sparelist.Add(new Sparepart_ML(item));
                }
                cmbSparepart.ItemsSource = sparelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            /*var ml = new Claim_ML(
                 (App.Current as App).policyid,
                 (App.Current as App).location,
                 (App.Current as App).reason,
                 (App.Current as App).knockedOn,
                 (App.Current as App)._3rdVehicleRegno,
                 (App.Current as App)._3rdOwnerName,
                 (App.Current as App)._3rdAddress,
                 (App.Current as App)._3rdContact,
                 (App.Current as App)._3rdRenewalDate,
                 (App.Current as App)._3rdSpecialNotes,
                 (App.Current as App).victimName,
                 (App.Current as App).victimAddress,
                 (App.Current as App).damageNature,
                 (App.Current as App)._3rdClaimant,
                 (App.Current as App)._3rdClaimAmount,
                 (App.Current as App).isDriverOwner,
                 (App.Current as App).drivername,
                 (App.Current as App).driverLicense,
                 (App.Current as App).driverCategories,
                 (App.Current as App).driverLicenseExpire,
                 (App.Current as App).driverNIC,
                 (App.Current as App).dateOfPrchase,
                 (App.Current as App).vehicleUsage,
                 (App.Current as App).rentName,
                 (App.Current as App).rentAmount,
                 SparepartList,
                 txtgarageCost.Text,
                 txtOtherCosts.Text,
                 txtDeductions.Text,
                 (App.Current as App).empid
                 );
            var result = JsonConvert.SerializeObject(ml);
            var data = await new ServiceReference1.Service1Client().InsertClaimAsync(result);

            if (data != -1)
            {
                var msg = String.Format("Your claim Id reference is {0}", data.ToString());
                var messageDialog = new Windows.UI.Popups.MessageDialog(msg);
                messageDialog.Title = "Successful";
                await messageDialog.ShowAsync();
                Frame.Navigate(typeof(Views.claimSuccess));
            }
            else
            {
                var msg = String.Format("Claiming failed.Please re submit.");
                var messageDialog = new Windows.UI.Popups.MessageDialog(msg);
                messageDialog.Title = "Failed";
                await messageDialog.ShowAsync();
            }*/
            UploadPhotos("4019");
        }

        private async void btnAddPart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtQuantity.Text == "")
                {
                    var messageDialog = new Windows.UI.Popups.MessageDialog("Enter quantity");
                    messageDialog.Title = "Required";
                    await messageDialog.ShowAsync();
                    return;
                }

                if (cmbSparepart.SelectedItem == null) return;

                var jsonselected = JsonConvert.SerializeObject(cmbSparepart.SelectedItem);
                var obj = JObject.Parse(jsonselected);
                var id = (string)obj["sparepartId"];
                var name = (string)obj["sparepartName"];
                var price = (string)obj["spareUnitCost"];
                lstboxSparelist.Items.Add(id + "- " + name + " Rs " + price + "/=  " + "  Qty: " + txtQuantity.Text);

                _totalcost += Convert.ToSingle(price) * Convert.ToInt32(txtQuantity.Text);
                txtSparecost.Text = _totalcost.ToString();

                SparepartList.Add(new SparepartPayment_ML()
                {
                    SparepartId = Convert.ToInt32(cmbSparepart.SelectedValue),
                    SparepartQty = Convert.ToDouble(txtQuantity.Text),
                    SparepartCost = Convert.ToDouble(price)
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var selected = lstboxSparelist.SelectedValue;
            var id = selected.ToString().Split('-')[0];


            var r = SparepartList.Where(n => n.SparepartId.ToString() == id).ToList();

            foreach (var item in r)
            {
                _totalcost = _totalcost - Convert.ToSingle(item.SparepartCost) * Convert.ToInt32(item.SparepartQty);
                txtSparecost.Text = _totalcost.ToString();
                SparepartList.Remove(item);
            }


            lstboxSparelist.Items.Remove(selected);
        }

        private void loadSparepartCatogoriesToCombo()
        {

            cmbSparePartCategory.ItemsSource = LocalSparepartCatogoryList;
        }

        private void loadSparepartManufacturersToCombo()
        {
            cmbSparepartManufacturer.ItemsSource = LocalSparepartmanufacturerList;
        }

        private void loadSparepartsToCombo()
        {
            try
            {
                var list = LocalSparepartsList;
                cmbSparepart.ItemsSource = list;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cmbSparePartCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var catname = cmbSparePartCategory.SelectedValue.ToString();
                var Manname = cmbSparepartManufacturer.SelectedValue;
                if (Manname != null)
                {
                    LoadSpareparts(Manname.ToString(), catname);
                }
                else
                {
                    LoadSpareparts("", catname);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbSparepartManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var Manname = cmbSparepartManufacturer.SelectedValue.ToString();
                var catname = cmbSparePartCategory.SelectedValue;
                if (catname != null)
                {
                    LoadSpareparts(Manname, catname.ToString());
                }
                else
                {
                    LoadSpareparts(Manname, "");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private double CalculateAmountPayable(double sparepartCost, double garageCost, double otherCost, double deduction, double insurancePercentage)
        {
            return ((sparepartCost + garageCost + otherCost) - deduction);
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
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

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        private void btnChoosePhotos_Click(object sender, RoutedEventArgs e)
        {
            ChoosePhotos();
        }

        public async void ChoosePhotos()
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            // Launch file open picker and caller app is suspended and may be terminated if required
            // await openPicker.PickMultipleFilesAsync();
            IAsyncOperation<IReadOnlyList<StorageFile>> asyncOp = openPicker.PickMultipleFilesAsync();
            fileList = await asyncOp;

            if (fileList != null)
            {
                var myPictures = new List<BitmapImage>();

                foreach (var item in fileList)
                {
                    var name = item.DisplayName;       
                    var stream = await item.OpenAsync(Windows.Storage.FileAccessMode.Read);
                    var image = new BitmapImage();
                    image.SetSource(stream);
                    myPictures.Add(image);
                    ImageListBox.Items.Add(image);
                }
            }
        }

        public async void UploadPhotos(string claimId)
        {
            try
            {
                if (fileList!=null)
                {
                    foreach (var item in fileList)
                    {
                        var res = ImageToBase64(item);
                        var name = item.DisplayName;
                        var fileExt = item.FileType;

                        var result = await _client.UploadImagesAsync(res.Result,name,claimId);
                    }  
                }   
            }
            catch (Exception)
            {
                
                throw;
            }           
        }

        public async Task<string> ImageToBase64(StorageFile MyImageFile)
        {
            try
            {
                Stream ms = await MyImageFile.OpenStreamForReadAsync();
                byte[] imageBytes = new byte[(int)ms.Length];
                ms.Read(imageBytes, 0, (int)ms.Length);
                return Convert.ToBase64String(imageBytes);
            }
            catch (Exception)
            {
                
                throw;
            }           
        }

        private void btnRemovePhoto_Click(object sender, RoutedEventArgs e)
        {
            ImageListBox.Items.Remove(ImageListBox.SelectedItem);
        }
    }
}
