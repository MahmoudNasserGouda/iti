using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class CustomerList : IEnumerable<Customer>, IEnumerator<Customer>
    {
        private Customer[] customers;
        int index = 0;
        public CustomerList()
        {
            customers = new Customer[10];
        }
        public Customer Current
        {
            get
            {
                return customers[index-1];
            }
        }
        object IEnumerator.Current
        {
            get { return customers[index - 1]; }
        }
        public void Add(int _index, Customer _customer)
        {
            customers[_index] = _customer;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public IEnumerator<Customer> GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            bool OKOrNot = index < customers.Length;
            index++;
            return OKOrNot;
        }
        public void Reset()
        {
           
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
