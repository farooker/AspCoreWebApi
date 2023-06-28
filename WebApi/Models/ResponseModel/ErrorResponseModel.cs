using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.ResponseModel
{
    public class ErrorResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorDetails Error { get; set; }
    }

    public class ErrorDetails
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }

}
