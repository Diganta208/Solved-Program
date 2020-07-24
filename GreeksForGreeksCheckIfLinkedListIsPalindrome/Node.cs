using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Node
    {

        private int data { get; set; }
        private Node next { get; set; }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }



        public void addToTial(int data, Node head)
        {
            if (head == null)
            {
                Node newHead = new Node(data);

            }
            else
            {
                Node currentNode = head;
                Node newNode = new Node(data);

                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }


                currentNode.next = newNode;
            }


        }

        private int CountNode(Node head)
        {
            Node CurrentNode = head;
            int count = 1;


            while (CurrentNode.next != null)
            {
                CurrentNode = CurrentNode.next;
                count++;
            }

            return count;
        }

        public void  isPalindrome(Node head)
        {
             int no=this.CountNode(head);
             int[] arr = new int[no];

             Node CurrentNode = head;

             int i = 0;
             while (CurrentNode.next != null)
             {
                 arr[i] = CurrentNode.data;
                 CurrentNode = CurrentNode.next;
                 i++;
             }

             arr[i] = CurrentNode.data;

            string str=null;

            for(int j=0; j<arr.Count(); j++)
            {
                str = str + arr[j].ToString();
            }

            string revStr = null;

            for (int j = arr.Count()-1; j >=0; j--)
            {
                revStr = revStr + arr[j].ToString();
            }

            if(str== revStr)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine(" Not Palindrome");
            }
        }

    }
}
