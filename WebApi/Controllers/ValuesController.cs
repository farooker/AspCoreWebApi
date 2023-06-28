using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApi.Constant;
using WebApi.Models.FarookModel;
using WebApi.Models.ResponseModel;
using WebApi.Service.FarookService;
using WebApi.Utils;

namespace WebApi.Controllers
{
    [Route("/api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[HttpGet]
        //[Route("values")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        private readonly IFarookService _farookService;
        public ValuesController(IFarookService farookService)
        {
            _farookService = farookService;
        }
        [HttpGet]
        [Route("values")]
        public ActionResult<SuccessResponseModel<string>> GetAll()
        {
            try
            {
                var data = _farookService.GetAll();
                var response = new SuccessResponseModel<IEnumerable<FarookModel>>();
                response.Success = true;
                response.Message =  "Find this list is sucessfully";
                response.Data = data;
                return Ok(response);
            }
            catch (ExceptionHandling e) {
                var response = e.ExceptionResponse(e);
                return StatusCode(e.ErrorCode, response);
            }
        }


        //public ActionResult<IEnumerable<FarookModel>> GetAll()
        //{
        //    var data = _farookService.GetAll();
        //    return Ok(data);
        //}

        //[HttpGet]
        //[Route("GetByid/{id}")]
        //public ActionResult<FarookModel> FindById([FromQuery]int id)
        //{
        //    var data = _farookService.FindById(id);
        //    return Ok(data);
        //}

        //[HttpPost]
        //[Route("/PostFarook")]
        //public ActionResult<FarookModel> AddFaRook([FromBody] FarookModel farookModel)
        //{
        //    var data = _farookService.Add(farookModel);
        //    return Ok(data);
        //}

        //[HttpPut]
        //[Route("/UpdateFarook")]
        //public ActionResult<FarookModel> PutFaRook(int id, [FromBody] FarookModel farookModel)
        //{
        //    var data = _farookService.Update(farookModel);
        //    return Ok(data);
        //}

        //[HttpDelete]
        //[Route("Remove/{id}")]
        //public ActionResult<int> Delete(int id)
        //{
        //    var data = _farookService.Remove(id);
        //    return Ok(data);
        //}
    }

}
