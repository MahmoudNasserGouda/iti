using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class EmployeeList
    {
        public EmployeeList()
        {
            _employees = new Employee[4];
        }      
        private Employee[] _employees;
        public Employee this[int _index]
        {
            get
            {
                return _employees[_index];
            }
            set
            {
                _employees[_index] = value;
            }
        }
        public Employee this[string _index]
        {
            
            get
            {
                Employee E =null;
                foreach(Employee emp in _employees)
                {
                    if (emp.Name == _index) {
                        E = emp;
                        break;
                    }
                }
                return E;
            }
        }
    }
}
