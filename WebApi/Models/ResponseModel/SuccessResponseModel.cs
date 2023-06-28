using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.ResponseModel
{
    public class SuccessResponseModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public PaginationInfo Pagination { get; set; }
        public T Data { get; set; }
    }
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
