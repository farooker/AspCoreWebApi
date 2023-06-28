using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repository
{

    public interface IProductsRepository
    {
        List<Products> GetAllProducts();
        Products GetProductById(int id);
    }
    public class ProductsRepository : IProductsRepository
    {
        private List<Products> _products;
        public ProductsRepository()
        {
            string folderPath = "Data";
            string fileName = "products.json";
            string filePath = Path.Combine(folderPath, fileName);
            string json = File.ReadAllText(filePath);
            _products = JsonConvert.DeserializeObject<List<Products>>(json);
        }
        public List<Products> GetAllProducts()
        {
            var data = _products;
            return data;
        }
        public Products GetProductById(int id)
        {
            var data = _products.FirstOrDefault(w=>w.Id.Equals(id));
            return data;
        }
    }
}
