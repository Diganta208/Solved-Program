using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given a singly linked list. The task is to find the length of the linked list, where length is defined as the number of nodes in the linked list.*/


            Node aNode = new Node(5);
            aNode.addToTial( 10, aNode);
            aNode.addToTial(15, aNode);
            aNode.addToTial(20, aNode);
            aNode.addToTial(25, aNode);
            aNode.addToTial(30, aNode);
            aNode.addToTial(35, aNode);

            aNode.CountNode(aNode);
            Console.ReadKey();
        }
    }
}
