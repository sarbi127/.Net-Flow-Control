using System;

namespace Uppgift2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            while (true)
            {
                System.Console.WriteLine("Type number and press the Enter Key:");
                System.Console.WriteLine( "0.  Exit ");
                System.Console.WriteLine( "1.  Checks whether a person is a pensioner or youth at the specified age.");
                System.Console.WriteLine( "2.  Checks number of people and total cost for the whole company.");
                System.Console.WriteLine( "3.  Please write what you want and it is scan 10 times.");
                System.Console.WriteLine( "4.  Please write at least three words and it is divides into words.");
                //try
                //{
                   int a = int.Parse(System.Console.ReadLine());

                    //int a;
                    string answer;
                    int  TCost;
                    Util util = new Util();

                    switch (a)
                    {
                        case 0:
                            {
                                return;
                            }
                        case 1:
                            {
                                Console.WriteLine("Enter your age:");
                                answer = Console.ReadLine();
                                util.Person(answer);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter how many we are going to the cinema:");
                                answer = Console.ReadLine();
                                TCost = util.TotalCost(answer);
                                Console.WriteLine( $"Number of people: {answer}, Total cost: {TCost} kr ");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Please write what you want");
                                answer = Console.ReadLine();
                                util.Scan(answer);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Please write at least 3 words");
                                answer = Console.ReadLine();
                                util.Split(answer);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(" It is incorrect input ");
                                break;
                            }
                    }
               // }
                //catch
                //{
                //}
            }
        }
    }
}
        
    

