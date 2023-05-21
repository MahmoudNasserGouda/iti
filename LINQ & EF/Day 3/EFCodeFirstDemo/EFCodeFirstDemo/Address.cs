using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    //Complex Type ==> composit Attr.
    internal class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }

        public Location Location { get; set; } = new Location();

        /* 
         * Complex Type Rules:
         * 1- Does not have any ID prop or [Key] Attr.
         * 2- Must declared as object inside the other class
         * 3- Must Not have any complex type (object from another class) 
         * */

    }

    [ComplexType]
    class Location
    {
        public string  Ay7aga { get; set; }

    }
}
