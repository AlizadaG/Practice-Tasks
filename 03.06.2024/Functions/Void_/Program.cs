using static System.Globalization.CultureInfo;
namespace Void_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ChangeTheSymb("strHGJH@ing", '@', '!'));

            Console.WriteLine("Adinizi giriniz");
            string firstName = Console.ReadLine();
            Console.WriteLine("Soyadinizi giriniz");
            string lastName = Console.ReadLine();
            Console.WriteLine("Domen adinizi giriniz");
            string domain = Console.ReadLine();
            CreateMail(firstName, lastName, domain);
        }
        private static void CreateMail(string firstName, string lastName, string? domain = "code.edu.az")
        {
            string mail = $"{ConvertToCapitalLetter(firstName)}.{ChangeTheSymb(ConvertToUpperCase(lastName), 'E', 'A')}@{domain}";
            Console.WriteLine(DeleteSymbols(mail));
        
        }
        public static string ConvertToUpperCase(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++) {
                char symb = str[i];
                if (symb >= 97 && symb<= 122)
                {
                    newStr += (char)(symb - 32);
                }
                else if(symb >=65 && symb <= 90)
                {
                    newStr +=symb;
                }
            }                
            return newStr;
        }
        public static string ConvertToLowerCase(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char symb = str[i];
                if (symb >= 97 && symb <= 122)
                {
                    newStr += symb;
                }
                else if (symb >= 65 && symb <= 90)
                {
                    newStr += (char)(symb + 32);
                }
            }
            return newStr;
        }
        public static string DeleteSymbols(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char symb = str[i];
                if (((symb >= 65 && symb <= 90 )|| ( symb >= 97 && symb <= 122)) || symb == 46 || symb == 64)
                {
                    newStr += symb;
                }
            }
            return newStr;
        }
        public static string ChangeTheSymb(string str, char oldSymb, char newSymb)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == oldSymb) newStr += newSymb;
                else newStr += str[i];
            }
            return newStr;
        }

        public static string ConvertToCapitalLetter(string str)
        {
            string newStr = ConvertToUpperCase(str[0].ToString());

            for (int i = 1; i < str.Length; i++)
            {
                newStr += ConvertToLowerCase(str[i].ToString());
            }
            return newStr;
        }
    }
}
