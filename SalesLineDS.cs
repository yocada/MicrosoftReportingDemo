using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftReportingDemo
{
    internal class SalesLineDS
    {
        public static List<SalesLine> getSalesLines()
        {
            var customers = constructCustomers();
            var items = constructItems();

            var res = new List<SalesLine>();

            var rndGenerator = new Random();

            for (int i = 1; i <= 25; i++)
            {
                var rndCustomer = "C000" + rndGenerator.Next(1, 11);
                var rndItem = "0000" + rndGenerator.Next(1, 11);
                var rndQty = rndGenerator.NextDouble() * 100;
                var rndUnitPrice = rndGenerator.NextDouble() * 100;

                var salesLine = new SalesLine();
                salesLine.CustAccount = rndCustomer;
                salesLine.CustName = customers[rndCustomer];
                salesLine.ItemId = rndItem;
                salesLine.Description = items[rndItem];
                salesLine.Qty = (decimal)rndQty;
                salesLine.UnitPrice = (decimal)rndUnitPrice;
                salesLine.TotalPrice = salesLine.Qty * salesLine.UnitPrice;

                res.Add(salesLine);
            }
            return res;
        }

        private static Dictionary<string, string> constructCustomers()
        {
            var customers = new Dictionary<string, string>();
            for (int i = 1; i <= 10; i++)
            {
                var custAccount = "C000" + i;
                var custName = "Customer " + i;
                customers[custAccount] = custName;
            }
            return customers;
        }

        private static Dictionary<string, string> constructItems()
        {
            var items = new Dictionary<string, string>();
            for (int i = 1; i <= 10; i++)
            {
                var itemId = "0000" + i;
                var itemName = "Item " + i;
                items[itemId] = itemName;
            }
            return items;
        }
    }
}
