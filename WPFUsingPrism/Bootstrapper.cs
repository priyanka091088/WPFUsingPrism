using EmployeeModule.ViewModel;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using ProductModule.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using System.Windows;
using ProductModule.View;
using EmployeeModule.View;
using Repository.Repository.Interface;
using Repository.Repository;

namespace WPFUsingPrism
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            Container.RegisterType<EmployeeViewModel>(new PerResolveLifetimeManager());
            Container.RegisterType<ProductViewModel>(new PerResolveLifetimeManager());

            Container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            Container.RegisterType<IProductRepository, ProductRepository>();
            Container.RegisterType<EmployeeView>(new PerResolveLifetimeManager());
            Container.RegisterType<ProductView>(new PerResolveLifetimeManager());
            return Container.Resolve<Shell>();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(DemoModule)); 
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
            
        }
    }
}
