using ObjectOrientedProblems.InventoryManger;
using System;

namespace ObjectOrientedProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run or exit
            bool isRun = true;
            InventoryManager inventoryData = new InventoryManager();
            string jsonFilePath1 = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\InventoryManger\InventoryList.json";
            StockAccountManagement.StockAccountManager stockAccount = new StockAccountManagement.StockAccountManager();
            string stockFilepath = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\StockAccountManagement\StockList.json";
            string transFilePath = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\StockAccountManagement\TransactionList.json";
            while (isRun)
            {
                // select program number to run
                Console.WriteLine("Enter the number of program to run.\n" +
                    "(1. InventoryDataJSON, 2. Inventory manager\n" +
                    "3. Stock Account management, 4. Stock data processing)");
                int selectNumber = Convert.ToInt32(Console.ReadLine());
                switch (selectNumber)
                {
                    case 1:
                        InventoryManagement inventory = new InventoryManagement();
                        string jsonFilePath = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\Inventory_JSON\InventoryList.json";
                        inventory.ListItems(jsonFilePath);
                        break;
                    case 2:
                        inventoryData.ReadData(jsonFilePath1);
                        inventoryData.Display();
                        break;
                    case 3:
                        stockAccount.TotalValue(stockFilepath);
                        break;
                    case 4:
                        stockAccount.BuyShares(stockFilepath,transFilePath);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
