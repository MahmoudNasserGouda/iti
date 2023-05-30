using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(50)]
        public string SSN { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MaxLength(50)]
        public string Phone { get; set; }
    }
}
