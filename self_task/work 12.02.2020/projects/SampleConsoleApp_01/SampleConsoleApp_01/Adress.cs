using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Adress
    {
        public int Postcode { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public Adress(int postcode, string town, string street, int house, int apartment)
        {
            Postcode = postcode;
            Town = town;
            Street = street;
            House = house;
            Apartment = apartment;
        }
        public override string ToString()
        {
            return "Postcode: " + Postcode + "Town: " + Town + "Street: " + Street
                + "House: " + House + "Apartment: " + Apartment;
        }
    }
}