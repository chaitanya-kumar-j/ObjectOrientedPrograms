using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProblems.InventoryManger
{
    class InventoryManager
    {
        List<InventoryModelJSON> riceList = new List<InventoryModelJSON>();
        List<InventoryModelJSON> wheatList = new List<InventoryModelJSON>();
        List<InventoryModelJSON> pulsesList = new List<InventoryModelJSON>();
        public void ReadData(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    InventoryFactory item = JsonConvert.DeserializeObject<InventoryFactory>(json);
                    riceList = item.Rice;
                    wheatList = item.Wheat;
                    pulsesList = item.Pulses;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void Display()
        {
            Console.WriteLine("Enter the itemtype to list:" +
                "(1. Rice, 2. Wheat, 3. Pulses)");
            int selectOption = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name\t\tWeight\t Cost");
            switch (selectOption)
            {
                case 1:
                    foreach (var item in riceList)
                    {
                        Console.WriteLine($"{item.ItemName}\t{item.ItemWeight}\t {item.ItemCost}");
                    }
                    break;
                case 2:
                    foreach (var item in wheatList)
                    {
                        Console.WriteLine($"{item.ItemName}\t {item.ItemWeight}\t {item.ItemCost}");
                    }
                    break;
                case 3:
                    foreach (var item in pulsesList)
                    {
                        Console.WriteLine($"{item.ItemName}\t {item.ItemWeight}\t {item.ItemCost}");
                    }
                    break;
            }
        }
    }
}
