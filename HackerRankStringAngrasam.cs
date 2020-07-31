using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Printing a Shape*/

            int no = Convert.ToInt32(Console.ReadLine());
            string[] dictionary = new string[no];
            int no1 = Convert.ToInt32(Console.ReadLine());
            string[]  query= new string[no1]; 

            for(int i=0; i<dictionary.Count(); i++)
            {
                dictionary[i]= Console.ReadLine();
            }

             for(int i=0; i<query.Count(); i++)
            {
                query[i]= Console.ReadLine();
            }

         List<int> result = new List<int>();
         int Count=0;

        for( int i=0; i<query.Count(); i++ )
        {
            char[] queryChar=query[i].ToCharArray();
            for(int j=0; j<dictionary.Count(); j++)
            {
                 char[] dictionaryChar=dictionary[j].ToCharArray();

                 if(queryChar.Count()==dictionaryChar.Count())
                 {
                      for( int m=0; m<queryChar.Count(); m++ )
                      {
                          if(m==queryChar.Count()-1 && dictionaryChar.Contains(queryChar[m]))
                          {
                              Count++;

                          }
                          else if(dictionaryChar.Contains(queryChar[m]))
                          {
                              continue;
                          }
                          else
                          {
                              break;
                          }

                      }
                 }

            }

            result.Add(Count);
            Count=0;
        }

        Console.WriteLine( result);

            
        Console.ReadKey();
        }
    }
}
