using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Uczelnia.Program
{
    internal class Backend
    {
        public static void Wybor()
        {
            var wybor = Convert.ToInt32(Console.ReadLine());
            if (wybor >= 1 && wybor <= 3)
            {
                switch (wybor)
                {
                    case 1:
                        LogIn();
                    break;
                    case 2:
                        SignIn();   
                    break;

                    case 3:
                        Environment.Exit(0);
                    break;
                }
            }
            else
            { Console.WriteLine("Niestety wcisnąłeś zły klawisz"); }
        }
        public static void LogIn()
        {
            string mail, pass;
            Console.Clear();
            Console.Write("Login:");
            mail = Console.ReadLine();
            Console.Write("Hasło:");
            pass = Console.ReadLine();
            if (mail == "admin" && pass == "admin")
            {
                Console.WriteLine("Udało ci się zalogować");
            }
            else
            {
                Console.WriteLine("Błędne hasło lub login");
            }
        }
        public static void SignIn()
        {
            string mail, pass;
            Console.Clear();
            Console.WriteLine("Podaj e-mail:");
            mail = Console.ReadLine();
            Console.Write("Podaj hasło:");
            pass = Console.ReadLine();
            
            Console.WriteLine("Zarejestrowano pomyślnie");
        }
    }
}
