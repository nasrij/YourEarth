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
using System.Windows.Media.Imaging;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;
using System.Windows.Shapes;
using Windows.Devices.Geolocation;

namespace YourEarth1.views
{
    public partial class Location : PhoneApplicationPage
    {
        public Location()
        {
            InitializeComponent();
            addlocation();
        }

        public void addlocation()
        {
            Grid MyGrid = new Grid();
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.Background = new SolidColorBrush(Colors.Transparent);

            //Creating a Rectangle
            Rectangle MyRectangle = new Rectangle();
            MyRectangle.Fill = new SolidColorBrush(Colors.Black);
            MyRectangle.Height = 20;
            MyRectangle.Width = 20;
            MyRectangle.SetValue(Grid.RowProperty, 0);
            MyRectangle.SetValue(Grid.ColumnProperty, 0);

            //Adding the Rectangle to the Grid
            MyGrid.Children.Add(MyRectangle);

            //Creating a Polygon
            Polygon MyPolygon = new Polygon();
            MyPolygon.Points.Add(new Point(2, 0));
            MyPolygon.Points.Add(new Point(22, 0));
            MyPolygon.Points.Add(new Point(2, 40));
            MyPolygon.Stroke = new SolidColorBrush(Colors.Black);
            MyPolygon.Fill = new SolidColorBrush(Colors.Black);
            MyPolygon.SetValue(Grid.RowProperty, 1);
            MyPolygon.SetValue(Grid.ColumnProperty, 0);
            //Adding the Polygon to the Grid
            MyGrid.Children.Add(MyPolygon);

            MapOverlay MyOverlay = new MapOverlay();
            MyOverlay.Content = MyGrid;
            GeoCoordinate myGeoCoordinate = new GeoCoordinate(Convert.ToDouble(models.Data.latitude) , Convert.ToDouble(models.Data.longitude));

            MyOverlay.GeoCoordinate = myGeoCoordinate;
            Mymap.Center = myGeoCoordinate;
            Mymap.ZoomLevel = 15;
            MyOverlay.PositionOrigin = new Point(0, 0.5);
            MapLayer MyLayer = new MapLayer();
            MyLayer.Add(MyOverlay);
            Mymap.Layers.Add(MyLayer);

            
            //  CoordinateConverter.ConvertGeocoordinate(myGeocoordinate);

        }
    }
}