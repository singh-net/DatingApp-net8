using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiExceptions(int statusCode, string message, string? details)
    {
        public int StatusCode { get; set; } = statusCode;
        public string message { get; set; } = message;
        public string? details { get; set; } = details;


    }
}