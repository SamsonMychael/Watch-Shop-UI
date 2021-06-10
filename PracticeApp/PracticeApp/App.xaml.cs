using Plugin.SharedTransitions;
using PracticeApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental" });
            MainPage = new SharedTransitionNavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
