﻿#pragma checksum "c:\users\nasri\documents\visual studio 2015\Projects\YourEarth1\YourEarth1\views\observation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9A95A07E76E5BE51B67D2146F5B9C80D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace YourEarth1.views {
    
    
    public partial class observation : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock nom;
        
        internal System.Windows.Controls.Image img;
        
        internal System.Windows.Controls.TextBlock theme;
        
        internal System.Windows.Controls.TextBlock date;
        
        internal System.Windows.Controls.TextBlock description;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/YourEarth1;component/views/observation.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.nom = ((System.Windows.Controls.TextBlock)(this.FindName("nom")));
            this.img = ((System.Windows.Controls.Image)(this.FindName("img")));
            this.theme = ((System.Windows.Controls.TextBlock)(this.FindName("theme")));
            this.date = ((System.Windows.Controls.TextBlock)(this.FindName("date")));
            this.description = ((System.Windows.Controls.TextBlock)(this.FindName("description")));
        }
    }
}

