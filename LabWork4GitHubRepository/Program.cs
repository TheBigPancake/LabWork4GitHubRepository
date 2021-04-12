using LabWork4GitHubRepository.TestClass;
using LabWork4GitHubRepository.Gorodensky;
using System;
using System.Collections.Generic;

namespace LabWork4GitHubRepository
{
    class Program
    {
        private static List<RunebleClass> classes = new List<RunebleClass>();
        static void Main(string[] args)
        {
            classes.Add(new GorodenskyClass());
            classes.Add(new ATestClass());
            Menu();
        }

        static private void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Работа с удаленными репозиториями\nВыбирете сообщение:");
                Console.WriteLine("\t1) Сообщение Городенского Станислава");
                Console.WriteLine("\t2) Тестовое сообщение");
                Console.Write("\t0) выход\n>");
            } while (ClearConsloeAndRunClass(int.Parse(Console.ReadLine())));
        }

        static private bool ClearConsloeAndRunClass(int key)
        {
            Console.Clear();
            if (key == 0) 
                return false;
            classes[key - 1].Run();
            return true;
        }
    }
}
