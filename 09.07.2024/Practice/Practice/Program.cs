using System.Drawing;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BalIf();
            BalSwitch();
            BalSwitchExpression();
        }

        public static void BalIf()
        {
            Console.WriteLine("Balinizi daxil edin");
            int bal = Convert.ToInt32(Console.ReadLine());
            string balHerf = "";
            if (bal > 100) balHerf = "Daxil edilmis bal 100 den boyuk ola bilmez";
            else if (bal > 90) balHerf = "A";
            else if (bal > 80) balHerf = "B";
            else if (bal > 70) balHerf = "C";
            else if (bal > 60) balHerf = "D";
            else if (bal > 50) balHerf = "E";
            else if (bal >= 0) balHerf = "F";
            else if (bal < 0) balHerf = "Daxil edilmis bal 0 dan kicik ola bilmez";
            
            Console.WriteLine(balHerf);
        }

        public static void BalSwitch()
        {
            Console.WriteLine("Balinizi daxil edin");
            int bal = Convert.ToInt32(Console.ReadLine());
            string balHerf = "";

            switch (bal)
            {
                case int n when n > 100 : 
                    balHerf = "Daxil edilmis bal 100 den boyuk ola bilmez";
                    break;
                case int n when n > 90 && n < 101 : 
                    balHerf = "A";
                    break;
                case int n when n > 80 && n < 91:
                    balHerf = "B";
                    break;
                case int n when n > 70 && n < 81:
                    balHerf = "C";
                    break;
                case int n when n > 60 && n < 71:
                    balHerf = "D";
                    break;
                case int n when n > 50 && n < 61:
                    balHerf = "E";
                    break;
                case int n when n >= 0 && n < 51:
                    balHerf = "F";
                    break;
                default: 
                    balHerf = "Daxil edilmis bal 0 dan kicik ola bilmez";
                    break;
            }
           
            Console.WriteLine(balHerf);
        }

        public static void BalSwitchExpression()
        {
            Console.WriteLine("Balinizi daxil edin");
            int bal = Convert.ToInt32(Console.ReadLine());
            string balHerf = "";

            balHerf = bal switch
            {
                < 101 and > 90 => "A",
                < 91 and > 80 => "B",
                < 81 and > 70 => "C",
                < 71 and > 60 => "D",
                < 61 and > 50 => "E",
                < 51 and > 0 => "F",
                _ => "Daxil edilmis bal 0-100 araliginda olmalidir"
            };

            Console.WriteLine(balHerf);
        }
    }
}
