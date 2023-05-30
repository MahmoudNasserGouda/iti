using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Book
    {
        public int ID { get; set; }

        [IsISBN]
        [MaxLength(50)]
        public string ISBN { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string PathOfImage { get; set; }

        public string Author { get; set; }

        public Category Category { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }
    }
}
