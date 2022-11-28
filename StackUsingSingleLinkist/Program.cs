using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class stack
    {
        node top;
        public stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            node fresh;
            fresh = new node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }
        public void pop()
        {
            Console.WriteLine("\n the poped elements is:" + top.info);
            top = top.next;
        }
        public void display()
        {
            node tmp;
            if(empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for(tmp = top; tmp !=null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
        static void main(string[] args)
        {
            stack s = new stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.Write("\nEnter your choice: ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':

                }
            }
        }
    }
}