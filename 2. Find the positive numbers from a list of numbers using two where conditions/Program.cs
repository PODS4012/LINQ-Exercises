using System;
using System.Linq;

namespace _2._find_the_positive_numbers_from_a_list_of_numbers_using_two_where_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
            Console.Write("\n-----------------------------------------------------------------------------");

            var nQuery =
            from VrNum in n1
            where VrNum > 0
            where VrNum < 12
            select VrNum;
            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
            foreach (var VrNum in nQuery)
            {
                Console.Write("{0}  ", VrNum);
            }
            Console.Write("\n\n");
        }
    }
}
