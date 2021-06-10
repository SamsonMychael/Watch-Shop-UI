using PracticeApp.Model;
using PracticeApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace PracticeApp.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set {
                products = value;
                OnPropertyChanged("Products");
            }
        }
        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set {
                selectedProduct = value;
               
            }
        }
        public void ShowDetails()
        {
            var page = new DetailPage() { BindingContext = new DetailVM { SelectedProduct = SelectedProduct } };
            App.Current.MainPage.Navigation.PushAsync(page);
        }
        private ObservableCollection<Menu> menus;

        public ObservableCollection<Menu> Menus
        {
            get { return menus; }
            set {
                menus = value;
                OnPropertyChanged("Menus");
            }
        }


        public MainVM()
        {
            Products = GetProducts();
            Menus = GetMenus();
        }
        private ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>()
            {
                new Product { Name = "Hilfi Watch", Price = 1954, Image = "charlesWatch.png", Model = "Model 2011", Rating = 4.5, Views = 4.5, Description = "Citizen is a watchmaking company which is headquartered in Tokyo, Japan. ..."},
                new Product { Name = "Gold Watch", Price = 1569, Image = "johnWatch.png", Model = "Model 2009", Rating = 4.5, Views = 4.5, Description = "yellow gold-toned watches are versatile enough to be worn with both casual and formal wear. Head to the mall, movies or a weekend outing dressed in shirts and jeans combinations, layered with jackets and boat shoes; accessorise with gold watches"},
                new Product { Name = "Citizens  Watch", Price = 2599, Image = "marekWatch.png", Model = "Model 2070", Rating = 4.5, Views = 4.5, Description = "Citizen watches have been an object of desire for men over a century now. If you’re looking for Citizen watches online, you’re at the right place. Our collection of Citizen watches will surely leave you spoilt for choice"},
                new Product { Name = "Rolex Watch", Price = 3999, Image = "rutgeWatch.png", Model = "Model 1997", Rating = 4.5, Views = 4.5, Description = "Kapoor Watch Company of Delhi is proud to be part of the worldwide network of Official Rolex Retailers, allowed to sell and maintain Rolex watches. We certify the authenticity of your new Rolex and back its five-year international guarantee with the necessary skills"},
            };
        }

        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>()
            {
                 new Menu { Icon = "order.png", Name = "My Order"},
                new Menu { Icon = "favorite.png", Name = "My WishList"},
                new Menu { Icon = "shopping.png", Name = "Shopping Cart"},
                new Menu { Icon = "settings.png", Name = "Settings"}
            };
        }
   

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
