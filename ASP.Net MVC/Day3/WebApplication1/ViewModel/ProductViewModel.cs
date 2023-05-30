using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Supplier { get; set; }

        public double Price { get; set; }
    }
}