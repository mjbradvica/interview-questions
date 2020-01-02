using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Interview.Domain.Infrastructure;
using Interview.Domain.Models;

namespace Interview.Domain
{
    public class HandleCustomer
    {
        public Logger Logger { get; set; }

        public HandleCustomer()
        {
            Logger = ServiceLocator.LocateService<Logger>();
        }

        public void HandlePayment()
        {
            //read some data from a file,
            //make an api call somewhere
            //write to a database
            //log something

            string[] lines = null;

            try
            {
                lines = System.IO.File.ReadAllLines("C:\\Users\\UserData.txt");
            }
            catch (FileNotFoundException fileNotFound)
            {
                Logger.LogMessage("file was not found");
                throw fileNotFound;
            }

            List<Order> orders = new List<Order>();

            for(int i = 0; i < lines.Count(); i++)
            {
                var fields = lines[i].Split(new char[]{','});

                string id = lines[i].Substring(0, 36);
                double price = Double.Parse(lines[i].Substring(36, lines[i].Length));

                Order order = new Order()
                {
                    OrderId = Guid.Parse(id),
                    OrderPrice = price
                };

                orders.Add(order);
            }
        }
    }
}
