using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day4Demo.ViewModels
{
    public class TopicVM
    {
        [Range(minimum:10, maximum:10000)]
        public int Top_Id { get; set; }

        [StringLength(50,MinimumLength =3)]
        [RegularExpression(@"^[a-zA-Z]{3,}$")]
        public string Top_Name { get; set; }
    }
}