using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourEarth1.models
{
    

        public class Rootobject
        {
            public ObservableCollection<Item> item { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public string image { get; set; }
            public string description { get; set; }
            public string longitude { get; set; }
            public string latitude { get; set; }
            public string date { get; set; }
            public string theme { get; set; }
            public string nom { get; set; }
        public string imgsource { get; set; }
        public string url { get; set; }

        public Item(string d,string lon,string lat,string date,string theme,string nom, string url)
        {
            description = d;
            longitude = lon;
            latitude = lat;
            this.date = date;
            this.theme = theme;
            this.nom = nom;
            this.url = url;
        }
    }

    
}
