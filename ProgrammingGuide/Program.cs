using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingGuide
{
    using ProgrammingGuide;
    class Program
    {
        // https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx
        static void Main(string[] args)
        {
            Array array = new Array();
            array.Order();
            array.LongLenght();

            int[] arr = new int[] { 4, 6, 11, 1, 5, 77, 8, 2, 99, 1 };
            Console.WriteLine($"Int array: ");
            Console.Write("\t");
            Array.PrintArray<int>(arr);

            string[] arr2 = new string[] { "Dung", "Luong", "Tien", "Sun", "Mon" };

            Console.WriteLine($"String array after reverse: ");
            Console.Write("\t");
            Array.ChangeArray<string>(arr2);

            Console.WriteLine($"String array after change some elements: ");
            Console.Write("\t");
            Array.ChangArrayElements(arr2);

            Array.SetArray<int>(out int[] arr3);
            Console.WriteLine(arr3.Length);

            Console.ReadKey();
        }
    }
}
