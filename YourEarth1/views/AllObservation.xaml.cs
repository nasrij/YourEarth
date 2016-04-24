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

namespace YourEarth1.views
{
    public partial class AllObservation : PhoneApplicationPage
    {
        public AllObservation()
        {
            InitializeComponent();
            getAllobservation();
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

       

        private void ListeObservation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (models.Item)ListeObservation.SelectedItem;
            models.Data.item = item;
            NavigationService.Navigate(new Uri("/views/observation.xaml", UriKind.Relative));
        }
    }
    

}