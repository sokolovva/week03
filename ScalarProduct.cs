using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int maxSum=0;
            List<int> v1 = new List<int>();
            string number = null;

            while ((number = Console.ReadLine()) != string.Empty)
            {
                v1.Add(int.Parse(number));
            }
            v1.Sort();
            int[] array = v1.ToArray();

            Console.WriteLine("enter second ");
            List<int> v2 = new List<int>();
            string number2 = null;

            while ((number2 = Console.ReadLine()) != string.Empty)
            {
                v2.Add(int.Parse(number2));
            }
            v2.Sort();
            int[] array2 = v2.ToArray();
            for (int i = 0; i <array.Length; i++)
            {
                sum = array[i] * array2[i];
                maxSum = maxSum + sum;
            }
            Console.WriteLine(maxSum);
            
            
        }
    }
}
