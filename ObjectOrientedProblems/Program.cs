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
                    "(1. InventoryDataJSON)");
                int selectNumber = Convert.ToInt32(Console.ReadLine());
                switch (selectNumber)
                {
                    case 1:
                        string jsonFilePath = @"G:\BridgeLabz\ObjectOrientedPrograms\ObjectOrientedProblems\Inventory_JSON\InventoryList.json";
                        new InventoryManagement().ListItems(jsonFilePath);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }

        }
    }
}
