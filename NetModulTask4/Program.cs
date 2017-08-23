using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Proses validate = new Proses();
            desain art = new desain();
            Console.Write("input number : ");
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("input your array {0} :",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            validate.sort(array, n);
            Console.WriteLine("----------------------------------------------------");
            art.seni(array, n);
         
        }
    }
}
