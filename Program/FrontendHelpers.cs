using Zadanie_Uczelnia.Program;

internal static class FrontendHelpers
{
    public static void OperationsScreen(Customer user)
    {
        Console.WriteLine($"Numer konta: {user.AccountNumber}");
        Console.WriteLine("Wybierz operację do wykonania:");
        Console.WriteLine("1. Wykonaj przelew");
        Console.WriteLine("2. Sprawdź balans swojego rachunku bankowego");
        Console.WriteLine("3. Wyloguj");
        Console.WriteLine("4. Wyloguj i zamknij aplikację");
    }
}