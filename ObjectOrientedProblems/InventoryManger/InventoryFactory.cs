using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProblems.InventoryManger
{
    class InventoryFactory
    {
        public List<InventoryModelJSON> Rice { get; set; }
        public List<InventoryModelJSON> Wheat { get; set; }
        public List<InventoryModelJSON> Pulses { get; set; }
    }
}
