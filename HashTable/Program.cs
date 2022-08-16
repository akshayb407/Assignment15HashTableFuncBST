using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(3);
            tree.Insert(56);
            tree.Insert(70);
            tree.Insert(30);
            tree.Display();

            
            
        }
    }
}
