using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given a singly linked list of size N of integers. The task is to check if the given linked list is palindrome or not.*/



            Node aNode = new Node(1);
            aNode.addToTial(2, aNode);
            aNode.addToTial(1, aNode);

            aNode.isPalindrome(aNode);
            Console.ReadKey();
        }
    }
}
