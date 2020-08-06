using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6_Task_7.Entities
{
    public class Market
    {
        private Queue<Client> _clients = new Queue<Client>();
        public Account Account { get; private set; } = new Account(0);

        public Market()
        { 
            
        }

        public int NumberOfClients() {
            return _clients.Count;
        }

        public Client NextClient()
        {
            return _clients.Dequeue();
        }

        public void AddClient(Client client)
        {
            _clients.Enqueue(client);
        }
    }
}
