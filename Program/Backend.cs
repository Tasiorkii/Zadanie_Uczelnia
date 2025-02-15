using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Uczelnia.Program
{
    internal class Backend
    {
        public List<Customers>? Client { get; set; }

        public void ChoiceStartup()
        {
            bool validChoice1 = false;
            while (!validChoice1)
                try
                {
                    var choice1 = Convert.ToInt32(Console.ReadLine());
                    if (choice1 >= 1 && choice1 <= 2)
                    {
                        switch (choice1)
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

        int accountID;
        string mail, pass;

        public void LogIn()
        {

            bool authorization = false; //zmienna do weryfikacji czy użytkownik jest prawidłowo zalogowany
            while (!authorization) //pętla, wykonuje się zawsze jeżeli zmienna authorization jest zawsze na false
            {
                Console.Clear();
                Console.Write("Login:");
                mail = Console.ReadLine();
                Console.Write("Hasło:");
                pass = Console.ReadLine();


                if (mail == "admin1" && pass == "admin1")
                {
                    Console.WriteLine(Frontend.succesReadLine);
                    Thread.Sleep(2000);
                    authorization = true;
                    accountID = 1;

                    AccountOperations();
                }
                else if (mail == "admin2" && pass == "admin2")
                {
                    Console.WriteLine(Frontend.succesReadLine);
                    Thread.Sleep(2000);
                    authorization = true;
                    accountID = 2;
                    AccountOperations();
                }
                else if (mail == "admin3" && pass == "admin3")
                {
                    Console.WriteLine(Frontend.succesReadLine);
                    Thread.Sleep(2000);
                    authorization = true;
                    accountID = 3;
                    AccountOperations();
                }
                else
                {
                    Console.WriteLine("Błędne hasło lub login, spróbuj wpisać ponownie.");
                    Thread.Sleep(3000); //Sleep aby użytkownik na 3 sekundy zobaczył że niepoprawnie został zalogowany
                }
            }
        }

        public void AccountOperations()
        {
            bool validChoice2 = false;
            Console.Clear();
            Frontend.OperationsScreen();

            while (!validChoice2)
                try
                {
                    var choice2 = Convert.ToInt32(Console.ReadLine());
                    if (choice2 >= 1 && choice2 <= 4)
                    {
                        switch (choice2)
                        {
                            case 1:
                                //cos tu sie dzieje
                                break;
                            case 2:
                                //cos tu sie dzieje
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Wylogowano poprawnie, przechodzenie do ekranu logowania");
                                Thread.Sleep(3000);
                                Console.Clear();
                                Frontend.StartupScreen();
                                ChoiceStartup();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Wylogowano poprawnie, wychodzenie z aplikacji...");
                                Thread.Sleep(2000);
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


        public void addClients()
        {
            //dodanie sztywnej "bazy" klientów
            Client = new List<Customers>();

            //klient 1
            Customers c1 = new Customers();
            c1.Id = 1;
            c1.Name = "Jan";
            c1.LastName = "Kowalski";
            c1.Balance = "2000";
            c1.Login = "admin1";
            c1.Password = "admin1";

            //klient 2
            Customers c2 = new Customers();
            c2.Id = 2;
            c2.Name = "Piotr";
            c2.LastName = "Nowak";
            c2.Balance = "3500";
            c2.Login = "admin2";
            c2.Password = "admin2";

            //klient 3
            Customers c3 = new Customers();
            c3.Id = 3;
            c3.Name = "Krzysztof";
            c3.LastName = "Pełka";
            c3.Balance = "12000";
            c3.Login = "admin3";
            c3.Password = "admin3";

        }

        public void showBalance()
        {
        }
    }
}