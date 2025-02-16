using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Zadanie_Uczelnia.Program
{
    internal class Backend
    {
        public List<Customer> Clients { get; set; }
        public Backend()
        {
            Clients = new List<Customer>();
            addClients();
        }
        public void addClients()
        {
            Clients.Add(new Customer(1, "Jan", "Kowalski", "12345678901234567890123456", 2000m, "login1", "login1"));
            Clients.Add(new Customer(2, "Piotr", "Nowak", "98765432109876543210987654", 3500m, "login2", "login2"));
            Clients.Add(new Customer(3, "Krzysztof", "Pełka", "56789012345678901234567890", 12000m, "login3", "login3"));
        }
        public void ChoiceStartup()
        {
            bool validChoice = false;
            while (!validChoice)
            {
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        LogIn();
                        validChoice = true;
                    }
                    else if (choice == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawny wybór, spróbuj ponownie.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Podaj liczbę.");
                }
            }
        }
        public void LogIn()
        {
            bool authorization = false;

            while (!authorization)
            {
                Console.Clear();
                Console.Write("Login: ");
                string mail = Console.ReadLine();
                Console.Write("Hasło: ");
                string pass = Console.ReadLine();

                var user = Clients.FirstOrDefault(c => c.Login == mail && c.Password == pass);

                if (user != null)
                {
                    Console.WriteLine("Zalogowano pomyślnie.");
                    Thread.Sleep(2000);
                    authorization = true;
                    AccountOperations(user);
                }
                else
                {
                    Console.WriteLine("Błędne dane logowania. Spróbuj ponownie.");
                    Thread.Sleep(2000);
                }
            }
        }
 public void AccountOperations(Customer user)
{
    bool running = true;
    while (running)
    {
        Console.Clear();
        Console.WriteLine($"Numer konta: {user.AccountNumber}");
        Frontend.OperationsScreen();
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Błąd: Podaj liczbę.");
            continue;
        }
        switch (choice)
        {
            case 1:
                Console.WriteLine("Podaj numer konta odbiorcy:");
                string recipientAccount = Console.ReadLine();
                Console.WriteLine("Podaj kwotę przelewu:");
                decimal amount;
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Błąd: Niepoprawna kwota.");
                    break;
                }
                MakeTransfer(user, recipientAccount, amount);
                Thread.Sleep(3000);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine($"Twój stan konta wynosi: {user.Balance} zł");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wciśnij dowolny klawisz, aby wrócić.");
                Console.ResetColor();
                Console.ReadLine();
                break;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wylogowano poprawnie, przechodzenie do ekranu logowania");
                Console.ResetColor();
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
            default:
                Console.WriteLine("Niepoprawny wybór.");
                break;
        }
    }
}
        public void MakeTransfer(Customer sender, string recipientAccount, decimal amount)
        {
            var recipient = Clients.FirstOrDefault(c => c.AccountNumber == recipientAccount);
            if (recipient == null)
            {
                Console.WriteLine("Błąd: Odbiorca nie istnieje.");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Błąd: Kwota musi być większa niż 0.");
                return;
            }
            if (sender.Balance < amount)
            {
                Console.WriteLine("Błąd: Brak wystarczających środków.");
                return;
            }
            sender.Balance -= amount;
            recipient.Balance += amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Przelew {amount} zł na konto {recipient.AccountNumber} ({recipient.Name} {recipient.LastName}) zakończony sukcesem!");
            Console.ResetColor();
        }
    }
}