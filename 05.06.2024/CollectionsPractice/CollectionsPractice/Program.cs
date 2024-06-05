namespace CollectionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            While();
        }
        public static void While()
        {
            List<int[]> list = new ();
            Random random = new Random();
            Console.Write("Arrayin olcusun daxil edin:");
            int len = Convert.ToInt32(Console.ReadLine());
            if(len > 0 && len <= 6)
            {
                int i = 0, count = 0;
                int[] nums = new int[len];
                while (count < len)
                {
                    nums = new int[len];
                    while (i < len)
                    {
                        int newRandom = random.Next(1, 50);
                        if (!CheckNumberExists(nums, newRandom, i))
                        {
                            nums[i] = newRandom;
                            i++;
                        }
                    }
                    list.Add(nums);
                    count++;
                    i = 0;
                }
                for (int k = 0; k < list.Count; k++)
                {
                    for (int l = 0; l < list[k].Length; l++)
                    {
                        Console.Write(list[k][l] + " ");
                    }
                    Console.WriteLine();
                }
            }else Console.Write("Arrayin olcusun 0 ve 6 araliginda daxil edin:");
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
