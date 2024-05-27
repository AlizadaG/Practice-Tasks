using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPractice.IfElse
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {
            SwitchCase1();
            SwitchCaseExpression();
        }
        public static void SwitchCase1()
        {
            string season = Console.ReadLine().ToLower();
            string fesil = "";
            switch (season)
            {
                case "winter":
                    {
                        fesil = "Qis";
                        break;
                    }
                case "spring":
                    {
                        fesil = "Yaz";
                        break;
                    }
                case "summer":
                    {
                        fesil = "Yay";
                        break;
                    }
                case "autumn":
                    {
                        fesil = "Payiz";
                        break;
                    }
                default:
                    {
                        fesil = "Bele fesil yoxdur";
                        break;
                    }
            }
            Console.WriteLine(fesil);
        }

        public static void SwitchCaseExpression()
        {
            string season = Console.ReadLine().ToLower();
            string fesil = season switch
            {
                "winter" => "Qis",
                "spring" => "Yaz",
                "summer" => "Yay",
                "autumn" => "Payiz",
                _ => "Bele fesil yoxdur"
            };
            Console.WriteLine(fesil);
        }

    }
}
