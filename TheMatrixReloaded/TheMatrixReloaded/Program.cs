using System;
using System.Globalization;

namespace TheMatrix
{
    class TheMatrix
    {
        //Массив представляет набор однотипных данных.
        //Массивы бывают динамические (их размер может меняться по ходу программы)
        //и статические (имеют определенный размер который не может меняться)
        static List<int> numbers = new List<int> {0};
        static bool cycle = true;
        private static void Main()
        {

            while (cycle)
            {
                Menu();
            }
        }
        private static void Menu()
        {
            Console.WriteLine("\n1 - вывести статичный массив" +
                "\n2 - вывести статичную матрицу" +
                "\n3 - вывести динамический массив" +
                "\n4 - изменить значения динамического массива" +
                "\n5 - вывести динамическю матрицу" +
                "\n6 - изменить динамическую матрицу");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ShowStaticArray();
                    break;
                case 2:
                    ShowStaticMatrix();
                    break;
                case 3:
                    ShowArray();
                    break;
                case 4:
                    EditArray();
                    break;
                case 5:
                    ShowMatrix();
                    break;
                case 6:
                    EditMatrix();
                    break;
                default:
                    Console.WriteLine("Error");
                    Menu();
                    break;
            }
        }
        private static void EditMatrix()
        {
            throw new NotImplementedException();
        }

        private static void ShowMatrix()
        {
            throw new NotImplementedException();
        }

        private static void EditArray()
        {
            Console.Write("Изменить элемент динамического массива №");
            int inp = Convert.ToInt32(Console.ReadLine())-1;  
            Console.Write(" на: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            if(inp > numbers.Count)
            {
                for(int i=numbers.Count; i<=inp; i++)
                {
                    numbers.Add(0);
                }
            }
            
            numbers[inp] = inp1;
            foreach (int num in numbers) { Console.WriteLine(num); }
        }

        private static void ShowArray()
        {
            foreach(int num in numbers) { Console.WriteLine(num); }
        }

        private static void ShowStaticMatrix()
        {
            int[,] nums1 = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 } };
            int rows = nums1.GetUpperBound(0) + 1;
            int cols = nums1.GetUpperBound(1) +1;
            for(int i=0; i < rows; i++)
            {
                for(int j = 0;j < cols; j++)
                {
                    Console.Write(nums1[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void ShowStaticArray()
        {
            int[] nums2 = new int[4];
            foreach(int i in nums2)
            {
                Console.Write (i);
            }
        }
    }
}
