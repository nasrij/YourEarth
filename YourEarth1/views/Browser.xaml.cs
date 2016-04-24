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
    public partial class Browser : PhoneApplicationPage
    {
        public Browser()
        {
            InitializeComponent();
            browser.Navigate(new Uri(models.Data.item.url, UriKind.Absolute));
        }
    }
}