﻿using Xamarin.Forms;

namespace SampleLocalApp
{
    public partial class App : Application
    {
        public static Color[] HighlightColors =
        {
            Color.FromHex("3C8A3F"), // Mi color
            Color.FromHex("3C91C8"),
            Color.FromHex("F75707"),
            Color.FromHex("AFFF3F"),
            Color.FromHex("59182A"),
            Color.FromHex("6616A2"),
            Color.FromHex("E8B254"),
            Color.FromHex("A57A30")
        };

        public static Color[] BackgroundColors =
        {
            Color.FromHex("eeeef2"), // My color
            Color.FromHex("FFFFFF"),
            Color.FromHex("E6E6E6"),
            Color.FromHex("CACAC9"),
            Color.FromHex("ADADAC"),
            Color.FromHex("979796"),
            Color.FromHex("646464"),
            Color.Black,
            Color.Default
        };

        public static HomeTabbedPage HomeTabbedPage;

        public App()
        {
            InitializeComponent();
            HomeTabbedPage = new HomeTabbedPage();
            MainPage = new NavigationPage(HomeTabbedPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}