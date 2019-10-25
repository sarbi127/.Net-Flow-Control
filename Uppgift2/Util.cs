using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    public class Util
    {
        //Checks whether a person is a pensioner or youth at the specified age.
        public void Person(string input)
        {
            int result = Int32.Parse(input);
            if( result < 5 || result > 100)
            {
                Console.WriteLine("Free");
            }
            else if (result < 20 )
            {
                Console.WriteLine("Youth price: 80kr");

            }
            else if (result > 64 )
            {
                Console.WriteLine("Pensioner price: SEK 90");
            }
            else
            {
                Console.WriteLine("Standard price: SEK 120");
            }

        }

        //Checks number of people and total cost for the whole company. 
         public int TotalCost(string num)
        {
            int result_num = Int32.Parse(num);
            string age;
            int result_cost;
            int sum = 0;

            for (int a = 1; a <= result_num; a = a + 1)
            {
                Console.WriteLine($"Enter age for person {a}");
                age = Console.ReadLine();
                result_cost = Int32.Parse(age);

                if (result_cost < 20)
                {
                    // Console.WriteLine(" Youth price: 80kr ");
                    sum += 80;
                }
                else if (result_cost > 64)
                {
                    //Console.WriteLine(" Pensioner price: SEK 90 ");
                    sum += 90;
                }
                else
                {
                    //Console.WriteLine(" Standard price: SEK 120 ");
                    sum += 120;
                }

            }

            return sum;
        }

        //write what you want and it is scan 10 times. 
        public void Scan(string sentenc)
        {
            for (int a = 1; a <= 10; a++)
            {
                Console.Write($"{a}.{sentenc},");
            }
        }

        //write what you want and it is scan 10 times. 
        public void Split(string phrase)
        {
            string[] words = phrase.Split(' ');
            if (words.Length >= 3)
            {
                //foreach (var word in words)
                //{
                System.Console.WriteLine($"<{words[2]}>");
                //}
            }
            else
            {
                System.Console.WriteLine($"Less than three words!");
            }
        }

    }
}
