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
    public partial class Eonet : PhoneApplicationPage
    {
        public Eonet()
        {
            InitializeComponent();
            getFromEonet();
        }

        public async void getFromEonet()
        {
            Random random = new Random();
            List<models.Item> list = new List<models.Item>();
            String url = "http://eonet.sci.gsfc.nasa.gov/api/v2.1/events?limit=5&days=20&source=InciWeb&status=open";
            HttpClient http = new HttpClient();
            HttpResponseMessage msg = await http.GetAsync(url);
            string webresponse = await msg.Content.ReadAsStringAsync();
            try
            {
                models.Eonet root = JsonConvert.DeserializeObject<models.Eonet>(webresponse);
                root.events[3].geometries[0].coordinates = root.events[2].geometries[0].coordinates;
                //ListeObservation.DataContext = root.item;
                //Data.listP = root.item;
                foreach (models.Eonet.Event ev in root.events )
                {
                    list.Add(new models.Item(ev.description, ev.geometries[0].coordinates[0].ToString(), ev.geometries[0].coordinates[1].ToString(), ev.geometries[0].date.Date.ToString(), ev.categories[0].title, ev.title, ev.sources[0].url));
                }
                ListeObservation.DataContext = list;

                    int x = 0;
                x++;
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
            NavigationService.Navigate(new Uri("/views/EonetItem.xaml", UriKind.Relative));

        }
    }
}