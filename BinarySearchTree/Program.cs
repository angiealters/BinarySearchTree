using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.AddNode(6);
            tree.AddNode(8);
            tree.AddNode(4);
            tree.AddNode(2);
            tree.AddNode(7);
            tree.Search(4);
        }
    }
}
