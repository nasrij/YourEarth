using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using YourEarth1.Resources;

using Microsoft.Phone.Notification;
using Microsoft.WindowsAzure.Messaging;

namespace YourEarth1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();
            if(models.Data.user != null)
            {
                DC.Text = "Disconnect";
            }
            else
            {
                DC.Text = "Connect";
            }
           /*var channel = HttpNotificationChannel.Find("MyPushChannel");
            if (channel == null)
            {
                channel = new HttpNotificationChannel("MyPushChannel");
                channel.Open();
                channel.BindToShellToast();
            }

            channel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(async (o, args) =>
            {
                var hub = new NotificationHub("<hub name>", "<connection string>");
                var result = await hub.RegisterNativeAsync(args.ChannelUri.ToString());

                System.Windows.Deployment.Current.Dispatcher.BeginInvoke(() =>
                {
                    MessageBox.Show("Registration :" + result.RegistrationId, "Registered", MessageBoxButton.OK);
                });
            });*/

            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.BackKeyPress += MainPage_BackKeyPress;
        }

        private void DrawerIcon_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();
            else
            {
                DrawerLayout.OpenDrawer();
                if(flech.Visibility == Visibility.Visible)
                {
                    flech.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Item_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
            {
                string menuItemName = grid.Name;
                MessageBox dialog = null;

                switch (menuItemName)
                {
                    case "Item1":
                        MessageBox.Show("Ay caramba!");
                        break;

                    case "Item2":
                        MessageBox.Show("Don't have a cow, man!");
                        break;

                    case "Item3":
                        MessageBox.Show("Hey, Ottoman!");
                        break;

                    case "Item4":
                        MessageBox.Show("Eat my shorts!");
                        break;
                }
            }
        }

        private void MainPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);

            if (DrawerLayout.IsDrawerOpen)
            {
                DrawerLayout.CloseDrawer();
                e.Cancel = true;
            }
        }

        private void All_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/views/AllObservation.xaml", UriKind.Relative));

        }

        private void Add_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if(models.Data.user == null)
            {
                NavigationService.Navigate(new Uri("/views/Coneexion.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/views/AjouterObservation.xaml", UriKind.Relative));
            }

        }

        private void Find_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/views/FindObservation.xaml", UriKind.Relative));
        }

        private void About_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/views/About.xaml", UriKind.Relative));

        }

        private void Connect_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DC.Text == "Connect")
                NavigationService.Navigate(new Uri("/views/Coneexion.xaml", UriKind.Relative));
            else
            {
                models.Data.user = null;
                DC.Text = "Connect";
            }
        }

        private void Eonet_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/views/Eonet.xaml", UriKind.Relative));
        }

        private void climateserv_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/views/Climateserv.xaml", UriKind.Relative));
        }
    }
}