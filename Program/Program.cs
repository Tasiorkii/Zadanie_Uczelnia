using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using Zadanie_Uczelnia.Program;
using static System.Net.Mime.MediaTypeNames;
string login, pass;


Console.WriteLine("Witaj w programie bankowym");
Console.WriteLine("Wybierz co chcesz zrobić:");
Console.WriteLine("1. Logowanie");
Console.WriteLine("2. Rejestracja");
Console.WriteLine("3. Wyjście");
var wybor=Convert.ToInt32(Console.ReadLine());
if (wybor >= 1 && wybor <= 3)
{

    switch (wybor)
    {
        case 1:
            Console.Clear();
            Console.Write("Login:");
            login = Console.ReadLine();
            Console.Write("Hasło:");
            pass = Console.ReadLine();
            if (login == "admin" && pass == "admin")
            {
                Console.WriteLine("Udało ci się zalogować");
            }
            else
            {
                Console.WriteLine("Błędne hasło lub login");
            }
            break;
        case 2:
            Console.Clear();
            Console.Write("Podaj login:");
            login = Console.ReadLine();
            Console.Write("Podaj hasło:");
            pass = Console.ReadLine();
            Console.WriteLine("Zarejestrowano pomyślnie");

            break;

        case 3:
            Console.ReadLine();
            Environment.Exit(0);
            break;


    }
}
else
{ Console.WriteLine("Niestety wcisnąłeś zły klawisz"); }



