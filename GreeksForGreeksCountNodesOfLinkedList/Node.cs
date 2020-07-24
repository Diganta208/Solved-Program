using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
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

        public void CountNode( Node head)
        {
            Node CurrentNode = head;
            int count = 1;


            while(CurrentNode.next!=null)
            {
                CurrentNode = CurrentNode.next;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
