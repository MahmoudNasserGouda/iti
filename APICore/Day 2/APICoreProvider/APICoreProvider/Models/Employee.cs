using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICoreProvider.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }

        //[JsonIgnore]
        public virtual Department Department { get; set; }
    }
}
