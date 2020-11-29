using System;
using System.Linq;

namespace _1._Shows_how_the_three_parts_of_a_query_operation_execute
{
    class Program
    {
        static void Main(string[] args)
        {
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");

            // The second part is Query creation.
            // nQuery is an IEnumerable<int>
            var nQuery =
                from VrNum in n1
                where (VrNum % 2) == 0
                select VrNum;

            // The third part is Query execution.
            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
            Console.Write("\n\n");
        }
    }
}
