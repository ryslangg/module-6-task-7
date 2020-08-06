using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_7.Entities;
using Module_6_Task_7.UI;

namespace Module_6_Task_7.MenuElements
{
    public class ServeClient : ElementMenu
    {
        public ServeClient()
        {
            Title = "Serve a client";
            Description = "serve the next customer in line";
            Key = '1';
        }

        public override void Do(ref Storage storage, Menu menu)
        {
            Client current = storage.Market.NextClient();
            bool alive = true;

            while (alive)
            {
                current.Cart.PrintAllProducts();
                Console.WriteLine("".PadRight(10, '_'));
                Console.WriteLine($"Summa:{current.Cart.Sum()}");

                if(current.Account.CheckAllowForWithdrawal(current.Cart.Sum()))
                {
                    current.Account.Sub(current.Cart.Sum());
                    storage.Market.Account.Add(current.Cart.Sum());
                    InOut.Alert($"Thank! I have completed my purchases!");
                    alive = false;
                }
                else
                {
                    InOut.Alert($"Sorry I don’t have enough funds, I’ll probably remove this item - {current.Cart.DropRandomProduct().Name}!"); 
                }
            }

            if(storage.Market.NumberOfClients() == 0)
            {
                InOut.Alert($"Congratulations, you have served all customers! Final balance - {storage.Market.Account.GetBalance()}$"); ;
                menu.Active = false;
            }
            
        }
    }
}
