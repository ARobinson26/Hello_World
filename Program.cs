using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
        static void AskQuestion (string question, string answer)
        {

        }

        static void Main(string[] args)
        {
            //Console.Title = "My First App!";

            //Console.WriteLine("Enter Your Age:");
            //string ageInput = Console.ReadLine();

            //int age = Convert.ToInt32(ageInput);

            //if (age > 18)
            //{
            //    Console.WriteLine("Adult");
            //}
            //else
            //{
            //    Console.WriteLine("Child");
            //}



            //Similar to an IF statement but doesn't search each condition, jumps to correct value.
            //The default section is where it defaults to if the correct.
            int productType = 7;
            switch (productType)
            {
                case 1:
                    {
                        Console.WriteLine("Product 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Product 2");
                        break;
                        
                    }
                default:
                    {
                        break;
                    }

            }
         
            //For loop.
            for (int i=0; i< 10000; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();
            
          
        }
    }
}
