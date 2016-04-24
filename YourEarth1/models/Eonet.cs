using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourEarth1.models
{
    public class Eonet
    {

        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public Event[] events { get; set; }

        public class Event
        {
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string link { get; set; }
            public Category[] categories { get; set; }
            public Source[] sources { get; set; }
            public Geometry[] geometries { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string title { get; set; }
        }

        public class Source
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Geometry
        {
            public DateTime date { get; set; }
            public string type { get; set; }
            public object[] coordinates { get; set; }
        }

    }
}
