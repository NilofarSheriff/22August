using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            string[][] classsection = new string[4][];
            classsection[0] = new string[] { "Abirami", "Bala", "chevireddy" };
            classsection[1] = new string[] { "Aham", "Brindha", "Israth" };
            classsection[2] = new string[] { "Varshini", "Nilofar", "Sathya","Abinaya" };
            classsection[3] = new string[] { "Janani", "Shobiya", "Preetha", "Shalini" };

            for(int i = 0; i < classsection.Length; i++)
            {
                Console.WriteLine("Row [{0}]:",i);
                for(int j = 0; j < classsection[i].Length; j++)
                {
                    Console.Write(classsection[i][j]+" ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }

}
