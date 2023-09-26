using System.Collections.Generic;

namespace _1._4Uzduotis_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char raide = 'K';
            //int raidesSkaicius = (int)raide;
            // Console.WriteLine(raidesSkaicius);


            //string zodis = "Klaipeda";
            //int sum = 0;
            //foreach (char raide in zodis)
            //{
            //    sum += raide;
            //}
            //Console.WriteLine(sum);


            List<string> list = new List <string> {"Vilnius", "Kaunas", "Klaipeda"};

            List<string> result = ChecksEvenNumbersSum(list);

            foreach (string s in result)
            {
            Console.WriteLine(s);
            }

        }
        public static List<string> ChecksEvenNumbersSum(List<string> list)
        {
            List<string> list2 = new List<string>();

            foreach (string word in list)
            {
                int sum = 0;
                foreach (char letter in word)
                {
                    sum += letter;
                }

                if (sum % 2 == 0)
                {
                list2.Add(word);
                }
            }
            return list2;
        }
    }
}