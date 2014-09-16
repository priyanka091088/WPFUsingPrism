using Repository.Model;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product(){ID=1,ProductCode="PRO001",ProductName="ABCD",ManufacturerName="Microsoft"},
                new Product(){ID=2,ProductCode="PRO002",ProductName="EFGH",ManufacturerName="Microsoft"},
                new Product(){ID=3,ProductCode="PRO003",ProductName="IJKL",ManufacturerName="Amazon"},
                new Product(){ID=4,ProductCode="PRO004",ProductName="MNOP",ManufacturerName="Microsoft"},
                new Product(){ID=5,ProductCode="PRO005",ProductName="QRST",ManufacturerName="Microsoft"}
            };
        }
    }
}
