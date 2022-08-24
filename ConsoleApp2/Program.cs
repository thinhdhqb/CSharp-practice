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
            List<int> list = Input_list();
            Min_max(list);
            Frequency(list);
            Console.ReadLine();
        }
        
        static List<int> Input_list()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + ": ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return list;
        }
        static void Min_max(List<int> list)
        {
            int max = list[0], min = list[0];
            foreach (int x in list)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine("MAX: " + max);
            Console.WriteLine("MIN: " + min);
        }

        static void Frequency(List<int> list)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int item in list)
            {
                if (dict.ContainsKey(item)) dict[item]++;
                else dict[item] = 1;
            }
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value + " times.");
            }
        }
    }
}