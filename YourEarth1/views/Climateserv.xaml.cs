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
    public partial class Climateserv : PhoneApplicationPage
    {
        public Climateserv()
        {
            InitializeComponent();
            myBrowser.Navigate(new Uri("http://climateserv.nsstc.nasa.gov/", UriKind.Absolute));
        }
    }
}