using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApi.Models.FarookModel;
using WebApi.Service.FarookService;

namespace WebApi.Controllers
{


    [Route("api/FarookApi")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFarookService _farookService;
        public ValuesController(IFarookService farookService)
        {
            _farookService = farookService;
        }
        [HttpGet]
        [Route("/GetAllFarook")]
        public ActionResult<IEnumerable<FarookModel>> GetAll()
        {
            var data = _farookService.GetAll();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetByid/{id}")]
        public ActionResult<FarookModel> FindById([FromQuery]int id)
        {
            var data = _farookService.FindById(id);
            return Ok(data);
        }

        [HttpPost]
        [Route("/PostFarook")]
        public ActionResult<FarookModel> AddFaRook([FromBody] FarookModel farookModel)
        {
            var data = _farookService.Add(farookModel);
            return Ok(data);
        }

        [HttpPut]
        [Route("/UpdateFarook")]
        public ActionResult<FarookModel> PutFaRook(int id, [FromBody] FarookModel farookModel)
        {
            var data = _farookService.Update(farookModel);
            return Ok(data);
        }

        [HttpDelete]
        [Route("Remove/{id}")]
        public ActionResult<int> Delete(int id)
        {
            var data = _farookService.Remove(id);
            return Ok(data);
        }

    }
 
}
