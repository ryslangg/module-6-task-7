using Module_6_Task_7.Entities;
using Module_6_Task_7.MenuElements;
using Module_6_Task_7.UI;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Module_6_Task_7
{
    class Program
    {
        private static Random _rand = new Random();
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddElement(new ServeClient());
            menu.AddElement(new Help());
            menu.AddElement(new Exit());

            Storage storage = new Storage();
            Market market = new Market();
            _generateClients(market);
            storage.Market = market;            

            while (menu.Active)
            {

                Console.Clear();
                InOut.BlockyPrint(new string[]
                {
                    $"Number of clients:{storage.Market.NumberOfClients()}",
                    $"Market balance:{storage.Market.Account.GetBalance()}$",
                });
                menu.Print();
                char keySymbol = Console.ReadKey(true).KeyChar;
                Console.Clear();
                menu.Run(keySymbol, ref storage);
            }
        }

        static void _possibleProductAddition(string name,double price, int chance, Client client)
        {
            if (_rand.Next(100) < chance) 
            {
                client.Cart.AddProduct(new Product(name, price));
            }
        }

        static void _generateClients(Market market)
        {
           
            int numberClients = _rand.Next(1,20);

            for(int i = 0; i<numberClients; i++)
            {
                Client client = new Client((double)_rand.Next(10,1000));
                int numberProds = _rand.Next(1, 10);
                _possibleProductAddition("bread",3,90,client);
                _possibleProductAddition("eggs", 4, 85, client);
                _possibleProductAddition("wine", 20, 65, client);
                _possibleProductAddition("chocolate", 50, 80, client);
                _possibleProductAddition("mobile phone", 300, 40, client);
                _possibleProductAddition("TV", 500, 20, client);
                _possibleProductAddition("notebook", 700, 10, client);
                _possibleProductAddition("cookie", 30, 75, client);
                market.AddClient(client);
            }
        }
    }
    
}
