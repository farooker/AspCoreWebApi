using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            List<NumberOfCompaniesWorkedDto> xx = new List<NumberOfCompaniesWorkedDto>();
            /*
            xx.Add(new NumberOfCompaniesWorkedDto()
            {
                Id = 1,
                Name = "Eon Technologies",
                Description = "Financial Technologies"
            });
            xx.Add(new NumberOfCompaniesWorkedDto()
            {
                Id = 2,
                Name = "Eon Technologies",
                Description = "Financial Technologies"
            });
            xx.Add(new NumberOfCompaniesWorkedDto()
            {
                Id = 3,
                Name = "Eon Technologies",
                Description = "Financial Technologies"
            });
            */
           // return Ok(xx.ToList());



            //List<string> xx =new List<string> {}
            /*
            var res = new JObject();
            JArray array = new JArray();
            array.Add("Manual text");
            array.Add(new DateTime(2000, 5, 23));
            res["id"] = 1;
            res["result"] = array;
            */

           return new string[] { "value1", "value2" ,};
          //  return Ok(Json("123"));
           //  return Content(res.ToString() ,"application/json");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string test)
        {


            return Ok(test); ; 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
         
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
          /*
            string connetionString = null;
            string id = "";
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-LS5NKKH\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                id ="Connection Open ! ";
                cnn.Close();
            }
            catch (Exception ex)
            {
                id = "Can not open connection ! ";
            }*/
         
    }
    public class NumberOfCompaniesWorkedDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
