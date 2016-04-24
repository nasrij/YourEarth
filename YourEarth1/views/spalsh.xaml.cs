using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;

namespace YourEarth1.views
{
    public partial class spalsh : PhoneApplicationPage
    {
        public spalsh()
        {
            InitializeComponent();
            wait();
        }

        private async void wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }
    }
}