using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingGuide
{
    class Array
    {
        //! You can store multiple variables of the same type in an array data structure. 
        //! You declare an array by specifying the type of its elements.
        //!? type[] arrayName

        // Declare a single-dimensional array set array element values
        int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };

        // Alternative syntax
        int[] arr2 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array
        int[,] multiDimensinalArray1 = new int[2, 3];

        // Declare and set array element values
        int[,] multiDimensinalArray2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        // describle multiple dimensinal array
        /*      columns  
         rows:  1 | 2 | 3
                4 | 5 | 6
         */

        //! Some buil-in methods of System.Array
        public void Order()
        {
            var orderedArray = arr2.OrderByDescending(x => x);
            foreach (var item in orderedArray)
            {
                Console.WriteLine(item);
            }
        }

        public void LongLenght()
        {
            //! Get all element 
            var obj = multiDimensinalArray1.LongLength;
            Console.WriteLine($"Long length of 2 demisions array: {obj}");

            var obj2 = arr1.LongLength;
            Console.WriteLine($"Long length of single demisions array: {obj2}");
        }

        //! Passing array as arguments
        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void ChangeArray<T>(T[] arr)
        {
            //! reverse index
            //!? e.g.: [a,b,f,g,u,i] => [i,u,g,f,b,a]
            arr = (arr.Reverse()).ToArray();
            PrintArray(arr);
        }

        public static void ChangArrayElements(string[] arr)
        {
            arr[0] = "Sun";
            arr[1] = "Mon";
            arr[2] = "Fri";
            arr[3] = "Tue";

            PrintArray<string>(arr);
        }

        //! Passing array with ref-out
        public static void SetArray<T>(out T[] arr)
        {           
            arr = new T[10];
        }
    }
}
