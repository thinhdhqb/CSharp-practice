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
            //Min_max();
            Frequency();
            Console.ReadLine();
        }

        static void Min_max()
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + ": ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int max = list[0], min = list[0];
            foreach (int x in list)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine("MAX: " + max);
            Console.WriteLine("MIN: " + min);
        }

        static void Frequency()
        {
            Console.WriteLine("============");
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>(n);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int val;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + ": ");
                val = Convert.ToInt32(Console.ReadLine());
                if (dict.ContainsKey(val)) dict[val]++;
                else dict[val] = 1;
                list.Add(val);
            }
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value + " times.");
            }
        }
    }
}