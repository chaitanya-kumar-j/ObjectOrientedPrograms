using System;

namespace ObjectOrientedProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run or exit
            bool isRun = true;
            while (isRun)
            {
                // select program number to run
                Console.WriteLine("Enter the number of program to run." +
                    "(1. InventoryDataJSON, 2. Inventory manager)");
                int selectNumber = Convert.ToInt32(Console.ReadLine());
                switch (selectNumber)
                {
                    case 1:
                        InventoryManagement inventory = new InventoryManagement();
                        string jsonFilePath = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\Inventory_JSON\InventoryList.json";
                        inventory.ListItems(jsonFilePath);
                        break;
                    case 2:
                        InventoryManger.InventoryManager inventoryData = new InventoryManger.InventoryManager();
                        string jsonFilePath1 = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\InventoryManger\InventoryList.json";
                        inventoryData.ReadData(jsonFilePath1);
                        inventoryData.Display();
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
