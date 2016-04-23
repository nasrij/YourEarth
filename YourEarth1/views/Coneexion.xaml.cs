using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Net.Http;

namespace YourEarth1.views
{
    public partial class Coneexion : PhoneApplicationPage
    {
        public Coneexion()
        {
            InitializeComponent();
        }

        private void login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (login.Text == String.Empty)
            {
                login.Text = "email ou pseudo";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                login.Foreground = Brush2;
            }
        }

        private void login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (login.Text == "email ou pseudo")
            {
                login.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                login.Foreground = Brush1;
            }
        }

        private void pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pass.Password.Length == 0)
                TextBlockEnterPassword.Visibility = Visibility.Visible;
            else
                TextBlockEnterPassword.Visibility = Visibility.Collapsed;

        }

        private void connecter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pass.Password == "Password")
            {
                pass.Password = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                pass.Foreground = Brush1;
            }
        }

        private void pass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pass.Password == String.Empty)
            {
                login.Text = "password";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                pass.Foreground = Brush2;
            }
        }

        private void tel_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tel.Text == String.Empty)
            {
                tel.Text = "Télephone";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                tel.Foreground = Brush2;
            }
        }

        private void tel_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tel.Text == "Télephone")
            {
                tel.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                tel.Foreground = Brush1;
            }
        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == "E-mail")
            {
                email.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                email.Foreground = Brush1;
            }
        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == String.Empty)
            {
                email.Text = "E-mail";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                email.Foreground = Brush2;
            }
        }

        private void pass1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pass1.Password.Length == 0)
                TextBlockEnterPassword1.Visibility = Visibility.Visible;
            else
                TextBlockEnterPassword1.Visibility = Visibility.Collapsed;

        }

        private void cpass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (cpass.Password.Length == 0)
                TextBlockEnterPassword2.Visibility = Visibility.Visible;
            else
                TextBlockEnterPassword2.Visibility = Visibility.Collapsed;

        }

        private async void Inscription_Click(object sender, RoutedEventArgs e)
        {
            string s;
            if (pass1.Password == cpass.Password)
            {
                String url = "http://192.168.43.39/YourEarth/inscrit.php";
                if (r1.IsChecked == true)
                {
                    s = r1.Content.ToString();
                }
                else
                {
                    s = r2.Content.ToString();
                }
                var values = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string> ("pseudo",login1.Text ),
                new KeyValuePair<string, string> ("tel", tel.Text),
                new KeyValuePair<string, string> ("password",pass1.Password),
                new KeyValuePair<string, string> ("sexe",s),
                new KeyValuePair<string, string> ("email",email.Text)
            };
                var httpClient = new HttpClient(new HttpClientHandler());
                HttpResponseMessage response = await httpClient.PostAsync(url, new FormUrlEncodedContent(values));
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();

                if (responseString.Equals("1"))
                {
                    MessageBox.Show("Utilisateur Existe deja");
                    pass1.Password = "";
                    cpass.Password = "";
                    //Frame.GoBack();
                }
                else
                {
                    MessageBox.Show("Utilisateur Ajouter");                    
                }
            }
            else
                MessageBox.Show("Mot de Passe incorrect");
        }

    

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String url = "http://192.168.43.39/YourEarth/login.php";
            var values = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string> ("pseudo",login.Text ),
                new KeyValuePair<string, string> ("password",pass.Password),
            };
            var httpClient = new HttpClient(new HttpClientHandler());
            HttpResponseMessage response = await httpClient.PostAsync(url, new FormUrlEncodedContent(values));
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            if(responseString.Equals("1"))
            {
                MessageBox.Show("Utilisateur Ajouter");

            }
            else
            {
                MessageBox.Show("Mot de Passe incorrect");

            }

        }

        private void login1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (login1.Text == String.Empty)
            {
                login1.Text = "Pseudo";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                login1.Foreground = Brush2;
            }
        }

        private void login1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (login1.Text == "Pseudo")
            {
                login1.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                login1.Foreground = Brush1;
            }
        }
    }
    }
