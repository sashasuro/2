using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                List ints = new List();
                Random rnd = new Random();
                ints.Add(rnd.Next(-8, 8));
                ints.Add(rnd.Next(-8, 8));
                ints.Add(rnd.Next(-8, 8));
                ints.Add(rnd.Next(-8, 8));
                ints.Add(rnd.Next(-8, 8));
                ints.Add(rnd.Next(-8, 8));
                Vivod(ints);
                Console.ReadKey();
         
            
        }
        static void Vivod(Listx)
        {
            //for (int i = 0; i < 8; i++)
            //{
            foreach (int ints in x)
            {
                Console.WriteLine(ints);
            }
            //}
        }
    }
}
