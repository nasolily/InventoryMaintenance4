using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem : IDisplayable
    {
        // Nadia Cowins
        public InvItem() { }

        // Nadia Cowins
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        // Nadia Cowins
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Nadia Cowins
        public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
    }
}
