﻿using Microsoft.Practices.Unity;
using ProductModule.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductModule.View
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        //public ProductView()
        //{

        //}
        public ProductView(IUnityContainer container)
        {
            InitializeComponent();
            this.DataContext = container.Resolve<ProductViewModel>();
        }
    }
}
