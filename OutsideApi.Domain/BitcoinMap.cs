using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Domain
{
    public class BitcoinMap
    {
        public string id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string description { get; set; }
        public string message { get; set; }
        public DateTime first_data_at { get; set; }
        public DateTime last_data_at { get; set; }
    }
}
