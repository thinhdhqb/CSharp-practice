using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + ": ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int max = list[0], min = list[0];
            foreach(int x in list)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine("MAX: " + max);
            Console.WriteLine("MIN: " + min);
            Console.ReadLine();
        }
    }
}
