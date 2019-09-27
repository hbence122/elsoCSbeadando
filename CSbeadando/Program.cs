using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSbeadando
{
    class Program
    {
        static List<int> szamok = new List<int>(10);

        static void Main(string[] args)
        {

            int db = 0;
            
            

            while (db != 10)
            {
                Console.WriteLine("Adjon meg egy számot!");
                szamok.Add(Convert.ToInt32(Console.ReadLine()));
                db++;
            }

            Console.WriteLine("A legnagyobb szám: " + szamok.Max());


            Console.ReadKey();
        }
    }


        
}
