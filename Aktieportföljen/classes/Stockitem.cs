using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aktieportföljen.classes
{
    public class Stockitem
    {
        // Unikt id
        public string Id { get; set; }
        // Large, Mid eller Small
        public string Stocklist { get; set; }
        // A eller B lista
        public string Stocktype { get; set; }
        // Namn på aktie
        public string Stockname { get; set; }
        // Pris för köp
        public string Buy { get; set; }
        // Pris för sälj
        public string Sell { get; set; }        
    }
}