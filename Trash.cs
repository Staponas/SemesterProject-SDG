using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada
{
    internal class Trash
    {
        enum TrashType
        {
            Paper,
            Plastic,
            Organic,
            Metal,
            Ewaste,
            Glass,
        }
        struct TrashItem
        {
            public string? Name;
            public TrashType Type;
            public int Quantity;
        }
        public static void SmartRecycling()
        {
            Console.Write("\r\n \r\n Here is a list of trash.\r\n \r\n");
            TrashItem[] trashItem = new TrashItem[]
            {
                new() {Name = "Bottle", Type = TrashType.Plastic, Quantity = 1 },
                new() {Name = "Can", Type = TrashType.Metal, Quantity = 1 },
                new() {Name = "Eggshell", Type = TrashType.Organic, Quantity = 3 },
                new() {Name = "Plastic Bags", Type = TrashType.Plastic, Quantity = 2 },
                new() {Name = "Zests", Type = TrashType.Organic, Quantity = 3 },//skrorka owocowa
                new() {Name = "Caps", Type = TrashType.Plastic, Quantity = 4 },
                new() {Name = "Withered flowers", Type = TrashType.Organic, Quantity = 2 },
                new() {Name = "Paper notes", Type = TrashType.Paper, Quantity = 3 },
                new() {Name = "Leaflet", Type = TrashType.Paper, Quantity = 1 },
                new() {Name = "Diary", Type = TrashType.Paper, Quantity = 1 },
                new() {Name = "Books", Type = TrashType.Organic, Quantity = 4 },
                new() {Name = "Computer", Type = TrashType.Organic, Quantity = 1 },
                new() {Name = "Mouse", Type = TrashType.Ewaste, Quantity = 1 },
                new() {Name = "Keyboards", Type = TrashType.Ewaste, Quantity = 2 },
                new() {Name = "Broken water glass", Type = TrashType.Glass, Quantity = 1 }
            };
            for (int i = 0; i < trashItem.Length; i++)
            {
                Console.WriteLine($"Number on the list {i + 1}");
                Console.WriteLine($"Name: {trashItem[i].Name}");
                Console.WriteLine($"Type: {trashItem[i].Type}");
                Console.WriteLine($"Quantity: {trashItem[i].Quantity}");
            }
        }
    }
}
