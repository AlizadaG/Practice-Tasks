namespace PracticeWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            While();
        }
        public static void While()
        {
            Random random = new Random();
            Console.Write("Arrayin olcusun daxil edin:");
            int len = Convert.ToInt32(Console.ReadLine());
            int i = 0, count = 0;
            int[] nums = new int[len];
            while (count < len)
            {
                while (i < len)
                {
                    int newRandom = random.Next(1, 50);
                    if (!CheckNumberExists(nums, newRandom, i))
                    {
                        nums[i] = newRandom;
                        Console.Write(nums[i] + " ");
                        i++;
                    }
                }
                Console.WriteLine();
                count++;
                i = 0;
            }
        }
        public static bool CheckNumberExists(int[] nums, int element, int say)
        {
            int i = 0;
            while (i < say)
            {
                if (nums[i] == element)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}
