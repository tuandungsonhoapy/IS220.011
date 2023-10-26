
using DAFramework.Models;
using System.Collections.Generic;

namespace DAFramework.Services
{
    public class ProductService : List<ProductModel>
    {
        public ProductService(){
            this.AddRange(new ProductModel[]{
                new ProductModel(){ID = 1, Name = "Áo phông", Price = 154000},
                new ProductModel(){ID = 2, Name = "Quần jean", Price = 134000},
                new ProductModel(){ID = 3, Name = "Áo khoác", Price = 234000},
                new ProductModel(){ID = 4, Name = "Áo sơ mi", Price = 314000}
            });
        }
    }
}