using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birinci = "Patika dev yazılım şirketi";
            string ikinci = "Patika dev yazılım şirketi";

            Console.WriteLine(birinci.Length);
            Console.WriteLine(birinci.CompareTo(ikinci)); // 1, -1, 0

            Console.WriteLine(birinci.ToUpper());
            Console.WriteLine(ikinci.ToLower());

            Console.WriteLine(birinci.Remove(1,2)); // pika
            Console.WriteLine(ikinci.PadRight(50, '-'));

            string [] dizi = ikinci.Split();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}