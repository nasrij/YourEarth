using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace YourEarth1.views
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
            List<models.image> list = new List<models.image>();
            list.Add(new models.image("/Assets/11.jpg"));
            list.Add(new models.image("/Assets/12.jpg"));
            list.Add(new models.image("/Assets/13.jpg"));
            list.Add(new models.image("/Assets/14.jpg"));
            liste.DataContext = list;
        }
    }
}