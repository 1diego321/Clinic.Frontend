﻿namespace Clinic.Domain.Models.Responses
{
    public class DefaultGetApiResponse<TData>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public TData Data { get; set; }
        public Metadata Metadata { get; set; }

        public DefaultGetApiResponse()
        {
            Success = false;
        }
    }
}