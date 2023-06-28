using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.ResponseModel;

namespace WebApi.Utils
{
    public class ExceptionHandling : Exception
    {
        public int ErrorCode { get; }
        public string ErrorMessage { get; }

        public ExceptionHandling(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
        public ErrorResponseModel ExceptionResponse(ExceptionHandling ex)
        {
            var response = new ErrorResponseModel();
            response.Success = false;
            response.Message = ex.ErrorMessage;
            response.Error = new ErrorDetails
            {
                Code = ex.ErrorCode,
                Message = ex.Message
            };
            return response;
        }
    }
}
