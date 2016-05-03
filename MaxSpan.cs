using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МaxSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> maxSpan = new List<int>();
            string number = null;

            while ((number = Console.ReadLine()) != string.Empty)
            {
                maxSpan.Add(int.Parse(number));
            }
        

            int[] array = maxSpan.ToArray();
            int counter = 0;
            int maxspan = 0;
            int temp = 0;
            for (int i = 0; i <array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    counter++;
                    if (array[i]==array[j])
                    {
                       
                        temp = counter;

                    }
                    counter = 0;
                    if (temp>maxspan)
                    {
                        maxspan = temp;
                    }   

                }
               



            }
            Console.WriteLine(maxspan);





        }
    }
}
