using System;
//using Uppgift2;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            //Test1   
            string number = "12";
            Util util = new Util();


            // act  

            int result = util.Person(number);

            //int stringToint = Int32.Parse(result);

            //var result = book.GetStatistics();


            // assert
            Assert.Equal(80 , result);
        }
    }

    internal class Util
    {

        public int Person(string input)
        {
            int result = Int32.Parse(input);
            if (result < 5 || result > 100)
            {
                //Console.WriteLine("Free");
                return 80;
            }
            else if (result < 20)
            {
                //Console.WriteLine("Youth price: 80kr");
                return 80;

            }
            else if (result > 64)
            {
                // Console.WriteLine("Pensioner price: SEK 90");
                return 90;
            }
            else
            {
                // Console.WriteLine("Standard price: SEK 120");
                return 120;
            }

        }
    }
}
