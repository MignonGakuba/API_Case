using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Case.Models
{
    public class Addresses
    {


        public int  Id { get; }
        public string Street { get; set; }

        public int HouseNumber { get; set; }
        public string City { get; set; }

        public string Country { get; set; }
        public string Zip_code { get; set; }


    }
}
