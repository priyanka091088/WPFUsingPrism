using EmployeeModule.View;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ProductModule.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUsingPrism
{
    class DemoModule : IModule
    {
        public IRegionManager region { get; set; }

        public IUnityContainer container { get; set; }

        public DemoModule(IRegionManager regionManager, IUnityContainer container)
        {
            this.region = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            var EmployeeRegion = this.region.Regions["EmployeeRegion"];
            var ProductRegion = this.region.Regions["ProductRegion"];

            EmployeeRegion.Add(container.Resolve<EmployeeView>(), "EmployeeView");
            ProductRegion.Add(container.Resolve<ProductView>(), "ProductView");

        }
    }
}
