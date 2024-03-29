﻿using System;
using System.Net;

namespace Entities.DTOs
{
    public class ErrorDetails : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public Object Error { get; }

        public ErrorDetails(HttpStatusCode code, object error = null)
        {
            Error = error;
            StatusCode = code;
        }

        public class GetCollegesHandle
        {
            public int StatusCode { get; set; }
            public string Message { get; set; }
        }
    }
}
