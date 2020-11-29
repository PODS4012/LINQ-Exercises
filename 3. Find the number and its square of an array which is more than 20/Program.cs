using System;
using System.Linq;

namespace _3._Find_the_number_and_its_square_of_an_array_which_is_more_than_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // code from DevCurry.com
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
            Console.Write("\n------------------------------------------------------------------------\n");

            var sqNo = from int Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { SqrNo, Number };

            foreach (var a in sqNo)
                Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
