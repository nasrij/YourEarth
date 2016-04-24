using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Media;

namespace YourEarth1.views
{
    public partial class FindObservation : PhoneApplicationPage
    {
        public FindObservation()
        {
            InitializeComponent();
        }

        public async void getAllobservation()
        {
            Random random = new Random();
            String url = "http://192.168.231.51/YourEarth/allobservation.php?format=json_wp&random=" + random.Next();
            HttpClient http = new HttpClient();
            HttpResponseMessage msg = await http.GetAsync(url);
            string webresponse = await msg.Content.ReadAsStringAsync();
            try
            {
                models.Rootobject root = JsonConvert.DeserializeObject<models.Rootobject>(webresponse);
                ListeObservation.DataContext = root.item;
                //Data.listP = root.item;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Server Might be Down");
            }
        }

        public async void findObservation()
        {
            Random random = new Random();
            String url = "http://192.168.231.51/YourEarth/findObservation.php?format=json_wp&random=" + random.Next()+ "&search="+search.Text;
            HttpClient http = new HttpClient();
            HttpResponseMessage msg = await http.GetAsync(url);
            string webresponse = await msg.Content.ReadAsStringAsync();
            try
            {
                models.Rootobject root = JsonConvert.DeserializeObject<models.Rootobject>(webresponse);
                ListeObservation.DataContext = root.item;
                //Data.listP = root.item;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Server Might be Down");
            }
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if(search.Text.Equals("Search ...") || search.Text.Equals(""))
            {
                getAllobservation();
            }
            else
            {
                findObservation();
            }
        }

        private void Image_GotFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == "Search ...")
            {
                search.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                search.Foreground = Brush1;
            }
        }

        private void Image_LostFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == String.Empty)
            {
                search.Text = "Search ...";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                search.Foreground = Brush2;
            }
        }
        private void ListeObservation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (models.Item)ListeObservation.SelectedItem;
            models.Data.item = item;
            NavigationService.Navigate(new Uri("/views/observation.xaml", UriKind.Relative));
        }
    }
}