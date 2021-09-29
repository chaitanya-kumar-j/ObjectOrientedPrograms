using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProblems
{
    class InventoryManagement
    {
        List<InventoryModelJSON> inventoryList = new List<InventoryModelJSON>();
        public void ListItems(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<InventoryModelJSON>>(json);
                    Console.WriteLine($"Name\t Weight\t Price");
                    foreach (var item in items)
                    {
                        Console.WriteLine($"{item.ItemName}\t {item.ItemWeight}\t {item.ItemCost}");
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
