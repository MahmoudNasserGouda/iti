using System;
using System.Collections.Generic;

#nullable disable

namespace MVC6EFDemo.Models
{
    public partial class ExtQuestion
    {
        public int? Id { get; set; }
        public string QuesText { get; set; }
        public string AnswerKeyWords { get; set; }
    }
}
