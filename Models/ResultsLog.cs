using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
