﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EEC.WebApp.MVC.Configuration
{
    public class CustomHttpRequestException : Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpRequestException() { }

        public CustomHttpRequestException(string message, Exception innerException)
            : base(message, innerException) { }

        public CustomHttpRequestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
