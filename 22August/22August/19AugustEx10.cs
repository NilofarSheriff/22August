using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class _19AugustEx10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 =  new Dictionary<int, string>();
            dict1.Add(1, "Rasikas");
            dict1.Add(2, "Althaf");
            dict1.Add(3, "Alarab");
            dict1.Add(4, "Crescent");
            Console.WriteLine("The added pairs in dictionary are: ");

            foreach (KeyValuePair<int, string> item in dict1)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadKey();

        }
    }
}
