using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCovid.Models
{
    public class Covid
    {

        public string Date { get; set; }
        public string State { get; set; }
        public string Death { get; set; }
        public string DeathIncrease { get; set; }
        public string HospitalizedCurrently { get; set; }
        public string HospitalizedIncreased { get; set; }
        public string OnVentilatorCurrently { get; set; }
        public string PositiveIncrease { get; set; }
    }
}
