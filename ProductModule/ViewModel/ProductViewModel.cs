using Microsoft.Practices.Prism.ViewModel;
using Repository.Model;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModule.ViewModel
{
    public class ProductViewModel : NotificationObject
    {
        private IProductRepository iProductRepository;

        public ProductViewModel(IProductRepository IProductRepository)
        {
            this.iProductRepository = IProductRepository;
            ProductList = new ObservableCollection<Product>();
            Init();
        }

        private ObservableCollection<Product> _productList;
        public ObservableCollection<Product> ProductList
        {
            get { return _productList; }
            set { _productList = value; RaisePropertyChanged("ProductList"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Init()
        {
            var emps = iProductRepository.GetAllProducts();
            foreach (Product item in emps)
            {
                ProductList.Add(item);
            }
        }
    }
}
