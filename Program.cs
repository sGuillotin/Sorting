using System.Security.Cryptography.X509Certificates;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] numbers2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };



            Console.Write("Before using Bubble Sort: ");
            foreach(int i in numbers1) {
                Console.Write(i + " ");
            }

            studentBubbleSort(numbers1);

            Console.Write("\nAfter using Bubble Sort:");
            foreach (int i in numbers1)
            {
                Console.Write(i + " ");
            }




            Console.Write($"\nBefore using C# Sort: ");
            foreach (int i in numbers2)
            {
                Console.Write(i + " ");
            }

            Array.Sort(numbers2);

            Console.Write("\nAfter using C# Sort: ");
            foreach (int i in numbers2)
            {
                Console.Write(i + " ");
            }
        }

        //student made bubble sort function
        public static void studentBubbleSort(int[] intArr)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                for (int j = 0; j < intArr.Length - i - 1; j++)
                {
                    if (intArr[j] > intArr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = intArr[j];
                        intArr[j] = intArr[j + 1];
                        intArr[j + 1] = temp;
                    }
                }
            }
        }
    }
}