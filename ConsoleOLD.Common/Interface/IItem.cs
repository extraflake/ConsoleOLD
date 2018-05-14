using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Interface
{
    public interface IItem
    {
        void Insert(string name, int price, int stock, int id);
        void Update(int id, int price);
        void Delete(int id);
        void Display();
    }
}
