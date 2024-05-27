namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Zehmet olmasa simvol daxil edin:");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char mySymb = keyInfo.KeyChar;
            Console.WriteLine("Sizin daxil etdiyiniz: " + mySymb);


            bool isLetter = Char.IsLetter(mySymb);
            bool isDigit = Char.IsDigit(mySymb);
            bool isLetterOrDigit = Char.IsLetterOrDigit(mySymb);
            if (isLetter) { 
                Console.WriteLine("Sizin daxil etdiyiniz simvol herfdir");
            }
            else
            {
                Console.WriteLine("Sizin daxil etdiyiniz simvol herf deyil");
            }
        }
    }
}
