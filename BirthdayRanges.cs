using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    class BirthdayRanges
    {
        static void Main(string[] args)
        {
            string number = null;
            Console.WriteLine("Enter birthdays: ");
            List<int> birthday = new List<int>();
            while ((number = Console.ReadLine()) != string.Empty)
            {
                birthday.Add(int.Parse(number));
            }
            

            List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>();
            Console.WriteLine("Enter ranges: ");
            int range =int.Parse(Console.ReadLine());
            for (int i = 0; i < range; i++)
            {
                ranges.Add(new KeyValuePair<int, int>());

            }
            BirthdaysRanges(birthday, ranges);

        }
        private static void BirthdaysRanges(List<int> birthdays, List<KeyValuePair<int,int>> ranges)
        {
            int count = 0;
            for (int i = 0; i < ranges.Count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (birthdays[j] >= ranges[i].Key && birthdays[j] <= ranges[i].Value)
                    {
                        count++;
                    }
                }
                Console.WriteLine("The result is: ");
                Console.WriteLine(count);
                
            }

            }

        }
    }

