using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Stack
    {
        char[] charArr;
        int top;
        public Stack( int no)
        {
            charArr = new char[no];
             top = 0;

        }

        public void push(char Data)
        {
            if(top>=charArr.Count())
            {
                Console.WriteLine("Array is Full");
            }
            else
            {
                this.charArr[top] = Data;
                top++;
            }
        }


        public char pop()
        {
            char item;
            if (top == 0)
            {
                Console.WriteLine("There is no element in this stack");
                return '-';
            }
            else
            {
                top--;
                item = charArr[top];
                return item;

            }
        }
    }
}
