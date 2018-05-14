using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Interface
{
    public interface ISupplier
    {
        void Add(string name);
        void Update(int id, string name);
        void Display();
        void Delete(int id);
    }
}
