using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProblems.StockAccountManagement
{
    class StockAccountManager
    {
        TransactionModel transaction = new TransactionModel();
        public void TotalValue(string filepath)
        {
            try
            {
                using StreamReader reader = new StreamReader(filepath);
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                Console.WriteLine("Company Name\t No. of Shares\t Price of Share\t Total Value");
                foreach (var item in items)
                {
                    item.TotalValue = item.NumberOfShares * item.PriceOfShare;
                    Console.WriteLine($"{item.CompanyName}\t {item.NumberOfShares}\t\t {item.PriceOfShare}\t\t {item.TotalValue}");
                }
                reader.Close();
                string result = JsonConvert.SerializeObject(items);
                File.WriteAllText(filepath, result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void BuyShares(string stockDataPath, string transDataPath)
        {
            using(StreamReader reader = new StreamReader(stockDataPath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                Console.WriteLine("Enter the company name");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter the amount");
                int amount = Convert.ToInt32(Console.ReadLine());
                
                transaction.ComanyName = companyName;
                transaction.TimeOfTransaction = Convert.ToString(DateTime.Now);
                foreach (var item in items)
                {
                    if (item.CompanyName == companyName)
                    {
                        transaction.PriceOfShare = item.PriceOfShare;
                        transaction.NumberOfShares = amount / item.PriceOfShare;
                        item.NumberOfShares += amount / item.PriceOfShare;
                        item.TotalValue = item.NumberOfShares * item.PriceOfShare;
                    }
                }
                reader.Close();
                string transactionString = Convert.ToString(JsonConvert.SerializeObject(transaction));
                File.WriteAllText(transDataPath, transactionString);
                string newStockData = JsonConvert.SerializeObject(items);
                File.WriteAllText(stockDataPath, newStockData);
                // File.AppendAllLines(transDataPath,transactionString);
            }
        }
        public void SellShares( string stockDataPath, string transDataPath)
        {
            using (StreamReader reader = new StreamReader(stockDataPath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                Console.WriteLine("Enter the company name");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter the amount");
                int amount = Convert.ToInt32(Console.ReadLine());

                transaction.ComanyName = companyName;
                transaction.TimeOfTransaction = Convert.ToString(DateTime.Now);
                foreach (var item in items)
                {
                    if (item.CompanyName == companyName)
                    {
                        transaction.PriceOfShare = item.PriceOfShare;
                        transaction.NumberOfShares = amount / item.PriceOfShare;
                        item.NumberOfShares -= amount / item.PriceOfShare;
                        item.TotalValue = item.NumberOfShares * item.PriceOfShare;
                    }
                }
                reader.Close();
                string transactionString = Convert.ToString(JsonConvert.SerializeObject(transaction));
                File.WriteAllText(transDataPath, transactionString);
                string newStockData = JsonConvert.SerializeObject(items);
                File.WriteAllText(stockDataPath, newStockData);
                // File.AppendAllLines(transDataPath,transactionString);
            }
        }
    }
}
