using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using Windows.Devices.Geolocation;
using System.IO;
using System.Net.Http;
using System.Windows.Media;

namespace YourEarth1.views
{
    public partial class AjouterObservation : PhoneApplicationPage
    {
        CameraCaptureTask cameraCaptureTask;

        public AjouterObservation()
        {
            InitializeComponent();
            List<String> themes = new List<string>();
            themes.Add("Choisir un theme");
            themes.Add("Earthquakes");
            themes.Add("Floods");
            themes.Add("Storms and tidal waves");
            themes.Add("Industrial accidents");
            themes.Add("Others");
            theme.DataContext = themes;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            cameraCaptureTask = new CameraCaptureTask();
            cameraCaptureTask.Completed += new EventHandler<PhotoResult>(cameraCaptureTask_Completed);
            cameraCaptureTask.Show();
        }

        void cameraCaptureTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage image1 = new BitmapImage();
                image1.SetSource(e.ChosenPhoto);
                image.Source = image1;
                image.Height = 250;
                //Code to display the photo on the page in an image control named myImage.
                //System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                //bmp.SetSource(e.ChosenPhoto);
                //myImage.Source = bmp;
            }
        }

        private async void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;
            String latitude="";
            String longitude="";
            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(1000)
                    );

                latitude = geoposition.Coordinate.Latitude.ToString("0.00");
                longitude = geoposition.Coordinate.Longitude.ToString("0.00");
            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    // the application does not have the right capability or the location master switch is off
                    //StatusTextBlock.Text = "location  is disabled in phone settings.";
                }
                //else
                {
                    // something else happened acquring the location
                }
            }
            String url = "http://192.168.231.51/YourEarth/addobservation.php";
            
            var values = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string> ("name",Nom.Text ),
                new KeyValuePair<string, string> ("description", description.Text),
                new KeyValuePair<string, string> ("theme",theme.SelectedItem.ToString()),
                new KeyValuePair<string, string> ("date",DateTime.Today.Date.ToString()),
                new KeyValuePair<string, string> ("latitude",latitude),
                new KeyValuePair<string, string> ("longitude",longitude),
                //new KeyValuePair<string, String> ("image",Convert.ToBase64String(ImageToArray())),
            };
            var httpClient = new HttpClient(new HttpClientHandler());
            HttpResponseMessage response = await httpClient.PostAsync(url, new FormUrlEncodedContent(values));
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            int x = 0;
            x++;
        }
        public byte[] ImageToArray()
        {
            BitmapImage image1 = new BitmapImage();
            image1 = image.Source as BitmapImage;
            WriteableBitmap wbmp = new WriteableBitmap(image1);
            MemoryStream ms = new MemoryStream();
            wbmp.SaveJpeg(ms, wbmp.PixelWidth, wbmp.PixelHeight, 0, 100);
            return ms.ToArray();
        }

        private void Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Nom.Text == "Nom Observation")
            {
                Nom.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                Nom.Foreground = Brush1;
            }
        }

        private void Nom_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Nom.Text == String.Empty)
            {
                Nom.Text = "Nom Observation";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                Nom.Foreground = Brush2;
            }
        }

        private void description_GotFocus(object sender, RoutedEventArgs e)
        {
            if (description.Text == "Description")
            {
                description.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                description.Foreground = Brush1;
            }
        }

        private void description_LostFocus(object sender, RoutedEventArgs e)
        {
            if (description.Text == String.Empty)
            {
                description.Text = "Description";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                description.Foreground = Brush2;
            }
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/views/AllObservation.xaml", UriKind.Relative));

        }
    }
}