using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApi.Constant
{
    public class HttpStatusCodes
    {
        public const HttpStatusCode Ok = HttpStatusCode.OK;
        public const HttpStatusCode Created = HttpStatusCode.Created;
        public const HttpStatusCode BadRequest = HttpStatusCode.BadRequest;
        public const HttpStatusCode NoContent = HttpStatusCode.NoContent;
        public const HttpStatusCode NotFound = HttpStatusCode.NotFound;
        public const HttpStatusCode Unauthorized = HttpStatusCode.Unauthorized;
        public const HttpStatusCode Forbidden = HttpStatusCode.Forbidden;
    }
}
