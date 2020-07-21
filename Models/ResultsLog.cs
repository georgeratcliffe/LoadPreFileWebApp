using System;
using System.ComponentModel.DataAnnotations;

namespace LoadPreFileWebApp.Models
{
    public class ResultsLog
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [MaxLength(200)]
        public string Message { get; set; }
    }
}
