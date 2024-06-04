namespace PracticeDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoWhile();
        }

        public static void DoWhile()
        {
            string userName = "Alizada", password = "Salam2407", name="", pass="";
            do
            {
                Console.Write("Kullanici ismini girin:");
                name = Console.ReadLine();
                Console.Write("Kullanici sifresini girin:");
                pass = Console.ReadLine();
                if(userName == name && password == pass)
                {
                    Console.WriteLine("Giris basarili!!!");
                    break;
                }
                else Console.WriteLine("Giris basarisiz.Tekrar deneyin!!!");

            } while (true);

        }
    }
}
