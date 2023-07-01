using System.Text.Json.Serialization;

namespace APICoreProvider.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //[JsonIgnore]
        public virtual List<Employee> Employees { get; set; } =new List<Employee>();

    }
}
