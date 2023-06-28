using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Models.ResponseModel;
using WebApi.Repository;

namespace WebApi.Service
{
    public interface IProductsService
    {
        List<Products> GetAllProducts();
        Products GetProductById(int id);
        SuccessResponseModel<IEnumerable<Products>>  GetFilterProducts();
    }
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public List<Products> GetAllProducts()
        {
            var action = _productsRepository.GetAllProducts();
            return action;
        }
        public SuccessResponseModel<IEnumerable<Products>> GetFilterProducts()
        {
            var data = _productsRepository.GetAllProducts();
            var response = new SuccessResponseModel<IEnumerable<Products>>();
            response.Success = true;
            response.Message = "Find list product is sucessfully";
            response.Data = data;
            response.Pagination = new PaginationInfo
            {
                TotalItems = 0,
                PageSize = 0,
                CurrentPage = 0,
                TotalPages = 0,
            };
            return response;
        }
        public Products GetProductById(int id)
        {
            var action = _productsRepository.GetProductById(id);
            return action;
        }
    }
}
