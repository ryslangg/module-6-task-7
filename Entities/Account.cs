using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6_Task_7.Entities
{
    public class Account
    {
        private double _balance = 0.0d;

        public Account(double _balance)
        {
            this._balance = _balance;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Add(double amount)
        {
            _balance += amount;
        }

        public void Sub(double amount) 
        {
            if(CheckAllowForWithdrawal(amount))
            {
                _balance -= amount;
            }
            
        }

        public bool CheckAllowForWithdrawal(double amount)
        {
            return (_balance - amount >= 0);
        }
    }
}
