namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeArray();
        }

        public static void PracticeArray(){
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

    }
}
