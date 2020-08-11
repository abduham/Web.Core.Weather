using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Core.Weather.Models
{
    public class Weather
    {
        [Key]
        public int ID { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Adjective { get; set; }
    }
}
