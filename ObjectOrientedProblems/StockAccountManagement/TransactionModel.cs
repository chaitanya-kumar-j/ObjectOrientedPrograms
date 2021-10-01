using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProblems.StockAccountManagement
{
    class TransactionModel
    {
        public string ComanyName { get; set; }
        public int NumberOfShares { get; set; }
        public int PriceOfShare { get; set; }
        public string TimeOfTransaction { get; set; }
    }
}
