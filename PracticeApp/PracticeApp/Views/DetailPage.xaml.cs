using PracticeApp.Model;
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
    public partial class DetailPage : ContentPage
    {
       
        public DetailPage()
        {
            InitializeComponent();
            
        }

        
        private void BackTapped(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}