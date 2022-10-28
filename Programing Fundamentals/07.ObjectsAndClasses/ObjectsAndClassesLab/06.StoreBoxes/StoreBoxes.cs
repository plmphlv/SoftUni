using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    internal class StoreBoxes
    {
        static void Main(string[] args)
        {
            List<Box> boxLedger = new List<Box>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string boxNumber = cmdArgs[0];
                string nameOfItemInBox = cmdArgs[1];
                int itemQty = int.Parse(cmdArgs[2]);
                decimal itemPrice = decimal.Parse(cmdArgs[3]);

                Box box = new Box(boxNumber, nameOfItemInBox, itemQty, itemPrice);
                boxLedger.Add(box);
            }

            foreach (Box box in boxLedger.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.BoxItem.ItemName} - ${box.BoxItem.ItemPrice:f2}: {box.Quantity}\r\n-- ${box.PricePerBox:f2}");
            }

            //-- Samsung - $1000.00: 10
        }
    }

    class Box
    {

        public Box(string serialNumber, string itemName, int itemQuantity, decimal itemPrice)
        {

            SerialNumber = serialNumber;
            BoxItem = new Item(itemName, itemPrice);
            Quantity = itemQuantity;

        }

        public string SerialNumber { get; set; }

        public Item BoxItem { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerBox
        {
            get
            {
                return Quantity * BoxItem.ItemPrice;
            }
        }

    }

    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }

    }
}