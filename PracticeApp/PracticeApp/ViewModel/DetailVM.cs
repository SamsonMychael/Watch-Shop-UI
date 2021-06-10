using PracticeApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PracticeApp.ViewModel
{
    public class DetailVM : INotifyPropertyChanged
    {
        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        { if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

       }
    }
}
