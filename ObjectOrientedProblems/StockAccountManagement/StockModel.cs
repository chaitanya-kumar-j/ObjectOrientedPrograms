﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProblems.StockAccountManagement
{
    class StockModel
    {
        public string CompanyName { get; set; }
        public int NumberOfShares { get; set; }
        public int PriceOfShare { get; set; }
        public int TotalValue { get; set; }
    }
}
