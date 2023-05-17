using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Account
    {
        public int Number { get; set; } = 10;
        private float balance;
        public float Balance
        {
            get { return balance; }
            set
            {
                if (value > 2000)
                    balance = value;
            }
        }
        public override string ToString()
        {
            return $"Number : {Number}, Balance : {Balance}";
        }
        public float Deposit(float _amount)
        {
            return Balance += _amount;
        }
        public bool Withdraw(float _amount)
        {
            bool ValidOrNot = Balance >= _amount;
            if (ValidOrNot) { Balance -= _amount; }
            return ValidOrNot;
        }
    }
}
