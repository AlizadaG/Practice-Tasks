namespace OutFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin radiusun qeyd edin:");
            int r = Convert.ToInt32(Console.ReadLine());
            CalculatorArea(r, out int area);
            Console.WriteLine("Dairenin sahesi: " + area);

            Console.WriteLine("Birinci terefi qeyd edin:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci terefi qeyd edin:");
            int b = Convert.ToInt32(Console.ReadLine());

            CalculatorArea(a,b, out int sahe);
            Console.WriteLine("Duzbucaqli ucbucagin sahesi:" + sahe);
        }
        static void CalculatorArea(int radius, out int area) {
            int pi = 3;
            area = pi * radius * radius;
        }
        static void CalculatorArea(int a, int b, out int area)
        {
            area = (a *  b) / 2;
        }
    }
}
