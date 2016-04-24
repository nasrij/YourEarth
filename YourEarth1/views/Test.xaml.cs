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
    public partial class Test : PhoneApplicationPage
    {
        /* public Test()
         {
             InitializeComponent();
         }
         private async void SubscribeButton_Click(object sender, RoutedEventArgs e)
         {
             var categories = new HashSet<string>();
             if (WorldCheckBox.IsChecked == true) categories.Add("World");
             if (PoliticsCheckBox.IsChecked == true) categories.Add("Politics");
             if (BusinessCheckBox.IsChecked == true) categories.Add("Business");
             if (TechnologyCheckBox.IsChecked == true) categories.Add("Technology");
             if (ScienceCheckBox.IsChecked == true) categories.Add("Science");
             if (SportsCheckBox.IsChecked == true) categories.Add("Sports");

             var result = await ((App)Application.Current).notifications.StoreCategoriesAndSubscribe(categories);

             MessageBox.Show("Subscribed to: " + string.Join(",", categories) + " on registration id : " +
                result.RegistrationId);
         }
         protected override void OnNavigatedTo(NavigationEventArgs e)
         {
             var categories = ((App)Application.Current).notifications.RetrieveCategories();

             if (categories.Contains("World")) WorldCheckBox.IsChecked = true;
             if (categories.Contains("Politics")) PoliticsCheckBox.IsChecked = true;
             if (categories.Contains("Business")) BusinessCheckBox.IsChecked = true;
             if (categories.Contains("Technology")) TechnologyCheckBox.IsChecked = true;
             if (categories.Contains("Science")) ScienceCheckBox.IsChecked = true;
             if (categories.Contains("Sports")) SportsCheckBox.IsChecked = true;
         }
     }*/
    }
}