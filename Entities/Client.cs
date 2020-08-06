using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6_Task_7.Entities
{
    public class Client
    {
        public Cart Cart { get; private set; } = new Cart();
        public Account Account { get; private set; } = null;

        public Client(double accountBalance)
        {
            Account = new Account(accountBalance);
        }

    
        
    }
}
