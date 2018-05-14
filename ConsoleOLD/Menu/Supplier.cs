using ConsoleOLD.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Menu
{
    public class Supplier
    {
        string name;
        int id;
        SupplierService _supplier = new SupplierService();
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
                    Console.Write("Supplier Name : ");
                    name = Console.ReadLine();
                    _supplier.Add(name);
                    break;
                case 2:
                    _supplier.Display();
                    break;
                case 3:
                    Console.Write("Id : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Supplier Name : ");
                    name = Console.ReadLine();
                    _supplier.Update(id, name);
                    break;
                case 4:
                    Console.Write("Id : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    _supplier.Delete(id);
                    break;
                default:
                    break;
            }
        }
    }
}
