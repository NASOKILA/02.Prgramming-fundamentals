namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AndreyAndBilliard
    {
        public static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> Shop = new Dictionary<string, decimal>();
            SetShop(productsCount, Shop);

            string clients = Console.ReadLine();
            List<Costumer> Clients = new List<Costumer>();
            SetCostumerShopList(clients, Clients, Shop);

            PrintClientProductQuantityAndBill(Clients, Shop);
        }

        private static void PrintClientProductQuantityAndBill(List<Costumer> Clients, Dictionary<string, decimal> Shop)
        {
            decimal totalBill = 0;
            foreach (var Client in Clients.OrderBy(x => x.Name))
            {
                string product = "";
                decimal quantity = 0;

                Console.WriteLine(Client.Name);
                foreach (var item in Client.BougthProductAndQuantity)
                {
                    product = item.Key;
                    quantity = item.Value;
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                }

                decimal fullBill = quantity * Shop[product];
                totalBill += fullBill;
                Console.WriteLine("Bill: {0:f2}", fullBill);
            }

            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }

        private static void SetCostumerShopList(string clients, List<Costumer> Clients,
            Dictionary<string, decimal> Shop)
        {

            while (!clients.Equals("end of clients"))
            {

                string[] NameProductQuantity = clients.Split(',', '-').ToArray();
                string name = NameProductQuantity[0];
                string product = NameProductQuantity[1];
                int quantity = int.Parse(NameProductQuantity[2]);

                if (Shop.ContainsKey(product))
                {

                    if (Clients.Any(c => c.Name == name))
                    {

                        Costumer costumer = Clients.First(c => c.Name == name);

                        if (!costumer.BougthProductAndQuantity.ContainsKey(product))
                        {
                            costumer.BougthProductAndQuantity.Add(product, quantity);
                        }
                        else
                        {
                            costumer.BougthProductAndQuantity[product] += quantity;
                        }

                        costumer.Bill += quantity * Shop[product];
                    }
                    else
                    {
                        Costumer costumer = new Costumer();
                        costumer.Name = name;
                        costumer.BougthProductAndQuantity = new Dictionary<string, int>();
                        costumer.BougthProductAndQuantity.Add(product, quantity);
                        costumer.Bill += quantity * Shop[product];

                        Clients.Add(costumer);
                    }
                }

                clients = Console.ReadLine();
            }
        }


        private static void SetShop(int productsCount, Dictionary<string, decimal> Shop)
        {
            for (int i = 0; i < productsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                string product = input[0];
                decimal price = decimal.Parse(input[1]);

                if (price > 9)
                    price = decimal.Parse(input[1]) / 100;

                Shop[product] = price;
            }
        }
    }
}

