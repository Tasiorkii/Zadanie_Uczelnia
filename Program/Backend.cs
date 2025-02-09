using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Uczelnia.Program
{
    internal class Backend
    {
        public static void Choice()
        {
            bool validChoice1 = false;
            while (!validChoice1)
                try
                {
                    var choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 1 && choice <= 2)
                    {
                        switch (choice)
                        {
                            case 1:
                                LogIn();
                                validChoice1 = true;
                                break;
                            case 2:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(Frontend.errorReadLineChoice);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(Frontend.errorReadLineChoice);
                }
        }

        public static void LogIn()
        {
            string mail, pass;
            bool authorization = false; //zmienna do weryfikacji czy użytkownik jest prawidłowo zalogowany
            while (!authorization) //pętla, wykonuje się zawsze jeżeli zmienna authorization jest zawsze na false
            {
                Console.Clear();
                Console.Write("Login:");
                mail = Console.ReadLine();
                Console.Write("Hasło:");
                pass = Console.ReadLine();

                if (mail == "admin" && pass == "admin")
                {
                    Console.WriteLine(Frontend.succesReadLine);
                    Thread.Sleep(2000);
                    authorization = true;
                }
                else
                {
                    Console.WriteLine("Błędne hasło lub login");
                    Thread.Sleep(3000); //Sleep aby użytkownik na 3 sekundy zobaczył że niepoprawnie został zalogowany
                }
            }
        }
    }
}
