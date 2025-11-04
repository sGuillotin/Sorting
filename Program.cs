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

            //studentBubbleSort(numbers1);

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
    }
}
