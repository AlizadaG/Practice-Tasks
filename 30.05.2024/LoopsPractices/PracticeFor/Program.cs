namespace PracticeFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            For();
            MinMax();
            EvenOdd();
            Sekiller();
            CarpimTablo();
            RandomTest();
        }
        public static void DigitsOfNumbers(int num)
        {
            int say = 0;
            int sum = 0;
            while (num > 0)
            {
                say++;
                sum += num % 10;
                num = (num - (num % 10)) / 10;
            }
            Console.WriteLine("Eded {0} reqemlidir ve reqemlerin cemi {1} dir", say, sum);
        }
        public static void For()
        {
            Console.WriteLine("Ededi daxil edin:");
            int num = Convert.ToInt32(Console.ReadLine());
            DigitsOfNumbers(num);
        }

        public static void MinMax()
        {
            int[] array = { 2, 4, 6, 7, 89, 9 };
            int min = array[0], max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Arraydeki minimum eded {0}-dir, maksimum eded {1}-dir", min, max);
        }
        public static void EvenOdd()
        {
            Console.WriteLine("Arrayin uzunlugun qeyd edin:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int evenCounter = 0, oddCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) evenCounter++;
                else oddCounter++;

            }
            Console.WriteLine("Arraydeki cut ededlerin sayi {0}-dir, tek ededlerin sayi {1} - dir", evenCounter, oddCounter);
        }

        public static void Sekiller()
        {
            Console.WriteLine("Kare boyutunu belirleyin:");
            int len = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(new String('-', 50));

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(new String('-', 50));

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (i == 0 || i == len - 1 || j == 0 || j == len - 1)
                    {
                        Console.Write("X ");
                    }
                    else Console.Write("Y ");
                }
                Console.WriteLine("");
            }
        }

        public static void CarpimTablo()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j);
                }
                Console.WriteLine(new String('-', 50));
            }
        }

        public static void RandomTest()
        {
            Random random = new Random();
            int num = random.Next(1000000, 100000000);
            Console.WriteLine("8 rakamli bir sayi giriniz");
            for (int i = 3; i >= 1; i--)
            {
                if (num == Convert.ToInt32(Console.ReadLine()))
                {
                    Console.WriteLine("Good game you win :)");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong answer, you have {0} changes", i - 1);
                }
            }
            Console.WriteLine("You could not find number, random number is {0}", num);
        }
    }
}
