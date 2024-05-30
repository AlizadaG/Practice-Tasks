using System.Diagnostics.CodeAnalysis;

namespace LoopsPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For();
            //MinMax();
            //EvenOdd();
            //Kare();
            //CarpimTablo();
            //RandomTest();
            //ForEach();
            While();
        }
    #region For

        public static void DigitsOfNumbers(int num)
        {
            int say = 0;
            int sum = 0;
            while (num > 0)
            {
                say++;
                sum += num%10;
                num = (num - (num%10))/10;
            }
            Console.WriteLine("eded {0} reqemlidir ve reqemlerin cemi {1} dir", say, sum);
        }
        public static void For()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            DigitsOfNumbers(num);
        }

        public static void MinMax()
        {
            int[] array = { 2,4,6,7,89,9};
            int min = array[0], max = array[0];
            for (int i = 0; i < array.Length; i++) {
                if (array[i] < min) { 
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
            Console.WriteLine("Arrayin uzunlugun qeyd edin");
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
            Console.WriteLine("Arraydeki cut ededlerin sayi {0}-dir, tek ededlerin sayi {1} - dir", evenCounter,oddCounter);
        }

        public static void Kare()
        {
            Console.WriteLine("Kare boyutunu belirleyin:");
            int len = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < len; i++)
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
                    if(i == 0 || i == len - 1 || j == 0 || j == len - 1)
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
            int num = random.Next(1000000,99999999);
            Console.WriteLine("8 rakamli bir sayi giriniz");
            for (int i = 3; i >= 1; i--)
            {
                if(num == Convert.ToInt32(Console.ReadLine()))
                {
                    Console.WriteLine("Good game you win :)");
                    return;
                }
                else {
                    Console.WriteLine("Wrong answer, you have {0} changes", i-1);
                }               
            }
            Console.WriteLine("you could not find number, random number is {0}" , num);
        }

        #endregion

        #region ForEach
        public static void ForEach()
        {
            Console.Write("Arrayin olcusun daxil edin:");
            int len = Convert.ToInt32(Console.ReadLine());
            if (len >= 0)
            {
                int[] array = new int[len];
                int[] divided2 = new int[0];
                int[] divided3 = new int[0];
                Console.WriteLine("{0} eded Array elementi daxil edin:", len);
                foreach (int j in array)
                {
                    array[j] = Convert.ToInt32(Console.ReadLine());
                    if (array[j] % 2 == 0)
                    {
                        Array.Resize(ref divided2, divided2.Length + 1);
                        divided2[divided2.Length - 1] = array[j];
                    }
                    if (array[j] % 3 == 0)
                    {
                        Array.Resize(ref divided3, divided3.Length + 1);
                        divided3[divided3.Length - 1] = array[j];
                    }
                }
                if (divided2.Length > 0)
                {
                    Console.Write("2-ye bolunen ededler: ");
                    ArrayList(divided2);
                }
                if (divided3.Length > 0)
                {
                    Console.Write("3-e bolunen ededler: ");
                    ArrayList(divided3);
                }
            }
            else
            {
                Console.WriteLine("Uzunluq sıfırdan böyük olmalıdır!!!");
            }
        }
        public static void ArrayList(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        #endregion

        #region While
        public static void While()
        {
            Console.Write("Arrayin olcusun daxil edin:");
            int len = Convert.ToInt32(Console.ReadLine());
            int k = 1; 
            while (k <= len) 
            {
                int[] nums = new int[len];
                Console.Write(k);
                k++;
            }
        }
        #endregion

        #region DoWhile
        public static void DoWhile()
            {
            }
        #endregion



        
    }
}
