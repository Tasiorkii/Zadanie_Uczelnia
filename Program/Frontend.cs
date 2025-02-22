﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Uczelnia.Program
{
    public static class Frontend
    {
        public static void StartupScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bank Łódzki S.A");
            Console.WriteLine("Dzień dobry, zaloguj się");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=======================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wybierz co chcesz zrobić:");
            Console.WriteLine("1. Logowanie");
            Console.WriteLine("2. Wyjście");
            Console.ResetColor();
        }
        public static void OperationsScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wybierz operację do wykonania:");
            Console.WriteLine("1. Wykonaj przelew");
            Console.WriteLine("2. Sprawdź balans swojego rachunku bankowego");
            Console.WriteLine("3. Wyloguj");
            Console.WriteLine("4. Wyloguj i zamknij aplikację");
            Console.ResetColor();
        }
    }
}
