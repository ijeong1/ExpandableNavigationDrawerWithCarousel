using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ExpandableNavigationDrawer
{
    public partial class MainPage : ContentPage
    {
        private bool _isExpanded;
        
        public MainPage()
        {
            InitializeComponent();
            expandableNavigation.HeightRequest = 50;


            List<String> Items = new List<String>();
            Items.Add("A");
            Items.Add("B");
            Items.Add("C");
            Items.Add("D");
            Items.Add("E");
            Items.Add("F");
            Items.Add("G");
            Items.Add("H");
            Items.Add("I");
            Items.Add("J");
            Items.Add("K");
            Items.Add("L");
            Items.Add("M");
            Items.Add("O");
            Items.Add("P");
            Items.Add("Q");
            Items.Add("R");
            Items.Add("S");
            Items.Add("T");
            Items.Add("U");
            Items.Add("V");
            Items.Add("W");
            Items.Add("X");
            Items.Add("Y");
            Items.Add("Z");

            listview.ItemsSource = Items;

            var list = new List<string>
            {
                "Hello World!",
                "This is a Carousel",
                "Caruosel is now available",
                "In Xamarin.Forms!"
            };
            TheCarousel.ItemsSource = list;

            _isExpanded = false;
            button.Text = "Show";
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (_isExpanded)
            {
                Action<double> callback = input => expandableNavigation.HeightRequest = input;
                double startingHeight = expandableNavigation.Height;
                double endingHeight = 50;
                uint rate = 16;
                uint length = 3000;
                Easing easing = Easing.CubicOut;
                expandableNavigation.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);
                _isExpanded = false;
                button.Text = "Show";
            }
            else
            {
                Action<double> callback = input => expandableNavigation.HeightRequest = input;
                double startingHeight = 50;
                double endingHeight = 250;
                uint rate = 16;
                uint length = 3000;
                Easing easing = Easing.CubicOut;
                expandableNavigation.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);
                _isExpanded = true;
                button.Text = "Hide";
            }
        }
    }
}
