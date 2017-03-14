using System;
using System.ComponentModel.DataAnnotations;

namespace Siotrix
{
    public class Error : Entity
    {
        [Required, Timestamp]
        public DateTime Timestamp { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public Error(Exception ex)
        {
            Source = ex?.Source;
            Message = ex?.Message;
            StackTrace = ex?.StackTrace;
        }
    }
}
