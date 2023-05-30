using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class UserBook
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Book Book { get; set; }

        public bool IsReturned { get; set; }

        public int Duration { get; set; }

        public DateTime BorrowedAt { get; set; }
    }
}
