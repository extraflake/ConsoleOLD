using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Menu
{
    public class Menu
    {
        public void Pilihan()
        {
            Console.WriteLine("======================");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("2. Item");
            Console.WriteLine("======================");
            Console.Write("Going to : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Supplier panggil = new Supplier();
                    panggil.Pilihan();
                    break;
                case 2:
                    Item call = new Item();
                    call.Pilihan();
                    break;
                default:
                    break;
            }
        }
    }
}
