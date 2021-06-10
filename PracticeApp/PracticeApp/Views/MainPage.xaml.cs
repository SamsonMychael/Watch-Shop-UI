using AndroidX.AppCompat.View.Menu;
using Plugin.SharedTransitions;
using PracticeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MainVM vm;
        public MainPage()
        {
            InitializeComponent();
            vm = Resources["vm"] as MainVM;
        }

        private void OpenMenu()
        {
            MenuGrid.IsVisible = true;

            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, -260, 0, 16, 300, Easing.CubicInOut);
        }

        private void CloseMenu()
        {
            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, 0, -260, 16, 300, Easing.CubicInOut);

            MenuGrid.IsVisible = false;
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, vm.SelectedProduct.Name);
            vm.ShowDetails();
        }

        private void OverlayTapped(object sender, EventArgs e)
        {
            CloseMenu();
        }
    }
}