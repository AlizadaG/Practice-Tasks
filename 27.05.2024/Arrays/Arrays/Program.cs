using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PracticeArrayCustom();
            //PracticeArray();
            //AverageArray();
            SimpleOrComplex();
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

        public static bool IsSimple(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void ArrayList(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void SimpleOrComplex()
        {
            Console.Write("Arrayin olcusun daxil edin:");
            int len = Convert.ToInt32(Console.ReadLine());
            if (len >= 0) {
                int[] numbers = new int[len];
                int[] complex = new int[0];
                int[] simple = new int[0];
                int[] notNatural = new int[0];
                Console.WriteLine("{0} eded Array elementi daxil edin:", len);
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = Convert.ToInt32(Console.ReadLine());
                    if (numbers[j] < 2)
                    {
                        Array.Resize(ref notNatural, notNatural.Length + 1);
                        notNatural[notNatural.Length - 1] = numbers[j];
                    }
                    else
                    {
                        if (IsSimple(numbers[j]))
                        {
                            Array.Resize(ref simple, simple.Length + 1);
                            simple[simple.Length - 1] = numbers[j];
                        }
                        else
                        {
                            Array.Resize(ref complex, complex.Length + 1);
                            complex[complex.Length - 1] = numbers[j];
                        }
                    }
                }
                if (notNatural.Length > 0)
                {
                    Console.Write("Ne sade nede murekkeb olmayan ededler: ");
                    ArrayList(notNatural);
                }
                if (simple.Length > 0)
                {
                    Console.Write("Sade ededler: ");
                    ArrayList(simple);
                }
                if (complex.Length > 0)
                {
                    Console.Write("Murekkeb ededler: ");
                    ArrayList(complex);
                }
            }
            else
            {
                Console.WriteLine("Uzunluq sıfırdan böyük olmalıdır!!!");
            }
            
        }
    }
}
