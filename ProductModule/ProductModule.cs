using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModule
{
    public class ProductModule : IModule
    {
        //public IRegionManager Region { get; set; }
        public void Initialize()
        {
            //Region.RequestNavigate("ProductRegion", "ProductView");
        }
    }
}
