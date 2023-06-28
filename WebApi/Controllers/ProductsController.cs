using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.ResponseModel;
using WebApi.Service;
using WebApi.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/product")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        [HttpGet]
        [Route("All")]
        public ActionResult<SuccessResponseModel<string>> FindProductAll()
        {
            try
            {
                var data = _productsService.GetAllProducts();
                var response = new SuccessResponseModel<IEnumerable<Products>>();
                response.Success = true;
                response.Message = "Find list product is sucessfully";
                response.Data = data;
                return Ok(response);
            }
            catch (ExceptionHandling e)
            {
                var response = e.ExceptionResponse(e);
                return StatusCode(e.ErrorCode, response);
            }
        }
        [HttpGet]
        [Route("Filter")]
        public ActionResult<SuccessResponseModel<string>> FindProductFilter()
        {
            try
            {
                var data = _productsService.GetFilterProducts();
                //var response = new SuccessResponseModel<IEnumerable<Products>>();
                //response.Success = true;
                //response.Message = "Find list product is sucessfully";
                //response.Data =;
                return Ok(data);
            }
            catch (ExceptionHandling e)
            {
                var response = e.ExceptionResponse(e);
                return StatusCode(e.ErrorCode, response);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<SuccessResponseModel<string>> FindProductById(int id)
        {
            try
            {
                var data = _productsService.GetProductById(id);
                var response = new SuccessResponseModel<Products>();
                response.Success = true;
                response.Message = "Find list product is sucessfully";
                response.Data = data;
                return Ok(response);
            }
            catch (ExceptionHandling e)
            {
                var response = e.ExceptionResponse(e);
                return StatusCode(e.ErrorCode, response);
            }
        }
    }
}
