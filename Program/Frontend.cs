using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Uczelnia.Program
{
    public static class Frontend
    {
        public static string errorReadLineChoice = "Niepoprawny wybór, spróbuj ponownie";
        public static string succesReadLine = "Operacja wykonana poprawnie";
        public static void PokazEkranPowitalny()
        {
            Console.WriteLine("Bank Łódzki S.A");
            Console.WriteLine("Dzień dobry, zaloguj się");
            Console.WriteLine("=======================");
            Console.WriteLine("Wybierz co chcesz zrobić:");
            Console.WriteLine("1. Logowanie");
            Console.WriteLine("2. Wyjście");
        }
        public static void OperationsScreen()
        {
            Console.WriteLine("Wybierz operację do wykonania:");
            Console.WriteLine("1. Przelew");
            Console.WriteLine("2. Wyjście");
        }
    }
}
