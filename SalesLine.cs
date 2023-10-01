using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftReportingDemo
{
    internal class SalesLine
    {
        public string CustAccount {  get; set; }
        public string CustName { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
