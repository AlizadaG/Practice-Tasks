namespace PracticeForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForEach();
        }
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
    }
}
