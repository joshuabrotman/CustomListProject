using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            int listLength;
            Console.WriteLine("Please enter how many digits you would like to enter into the array:");
            listLength = Convert.ToInt32(Console.ReadLine());

            ArrayList<int> newList = new ArrayList<int>();

            for(int i = 0; i < listLength; i++)
            {
                Console.WriteLine("Enter the next digit: ");
                Console.ReadLine();
            }

        }

    }
}
