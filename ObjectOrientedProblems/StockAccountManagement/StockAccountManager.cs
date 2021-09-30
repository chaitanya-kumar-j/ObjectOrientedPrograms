using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProblems.StockAccountManagement
{
    class StockAccountManager
    {
        public void ListCompany(string filepath)
        {
            try
            {
                using StreamReader reader = new StreamReader(filepath);
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                Console.WriteLine("Company Name\t No. of Shares\t Price of Share\t Total Value");
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.CompanyName}\t {item.NumberOfShares}\t\t {item.PriceOfShare}\t\t {item.NumberOfShares * item.PriceOfShare}");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
