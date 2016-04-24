using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.Media;
using System.Net.Http;
using Microsoft.Phone.Tasks;
using System.IO;
using Microsoft.Xna.Framework.Media.PhoneExtensions;

namespace YourEarth1.views
{
    public partial class observation : PhoneApplicationPage
    {
        public observation()
        {
            InitializeComponent();
            nom.Text = models.Data.item.nom;
            date.Text = models.Data.item.date;
            theme.Text = models.Data.item.theme;
            description.Text = models.Data.item.description;
            img.DataContext = models.Data.item.image;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            models.Data.latitude = models.Data.item.latitude;
            models.Data.longitude = models.Data.item.longitude;
            NavigationService.Navigate(new Uri("/views/Location.xaml", UriKind.Relative));
        }

        private async void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            MediaLibrary mediaLibrary = new MediaLibrary();
            string url = models.Data.item.image;
            HttpClient client = new HttpClient();
            byte[] responseBytes = await client.GetByteArrayAsync(url);
            var picture = mediaLibrary.SavePicture(Path.GetFileName(models.Data.item.image), responseBytes);
            Microsoft.Phone.Tasks.ShareMediaTask smt = new ShareMediaTask();
            smt.FilePath = picture.GetPath();
            smt.Show();
        }
    }
}