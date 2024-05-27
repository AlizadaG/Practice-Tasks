using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeArrayCustom();
            PracticeArray();
            AverageArray();
        }

        public static void PracticeArrayCustom(){
            int[] numbers = { 0, 50, -11, 23, 18 };
            int min = 0, index = 0;
            for (int i = 0; i < numbers.Length; i++) { 
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    index = i;
                }
            }
            Console.WriteLine("Minimum eded {0} - dir ve indeksi {1}- dir", min, index);
        }

        public static void PracticeArray()
        {
            int[] numbers = { 0, 50, -11, 23, 18 };
            Array.Sort(numbers);
            Console.WriteLine("Minimum eded {0} - dir", numbers[0]);
           
            int min = 0, index = 0;
            Array.ForEach(numbers, n =>
            {
                if (n < min)
                {
                    min = n;
                    index = Array.IndexOf(numbers, n);
                }
            });
            Console.WriteLine("Minimum eded {0} - dir ve indeksi {1}- dir", min, index);
        }

        public static void AverageArray()
        {
            int[] numbers = { 0, 50, -11, 23, 18 };
            int sum = 0;
            float avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("Arrayin ortalamasi {0} - dir", avg);
        }

    }
}
