using ConsoleOLD.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Menu
{
    public class Item
    {
        string name;
        int id, price, stock, supplier;
        ItemService _item = new ItemService();
        public void Pilihan()
        {
            Console.WriteLine("======================");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("======================");
            Console.Write("Going to : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Item Name : ");
                    name = Console.ReadLine();
                    Console.Write("Price : ");
                    price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Stock : ");
                    stock = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Supplier : ");
                    supplier = Convert.ToInt32(Console.ReadLine());
                    _item.Insert(name, price, stock, supplier);
                    break;
                case 2:
                    _item.Display();
                    break;
                case 3:
                    Console.Write("Id : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Price : ");
                    price = Convert.ToInt32(Console.ReadLine());
                    _item.Update(id, price);
                    break;
                case 4:
                    Console.Write("Id : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    _item.Delete(id);
                    break;
                default:
                    break;
            }
        }
    }
}
