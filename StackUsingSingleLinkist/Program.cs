using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node next;
        public node(int i, int n)
        {
            info = i;
            next = n;
        }
    }
    class stack
    {
        node top;
        public stack;
    }
}