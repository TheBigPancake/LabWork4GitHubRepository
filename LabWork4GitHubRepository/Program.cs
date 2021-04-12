using System;

namespace LabWork4GitHubRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static private void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Вариант 2\nвыбирите задание:");
                Console.WriteLine("1) задача 1");
                Console.WriteLine("2) задача 2");
                Console.WriteLine("3) задача 3");
                Console.Write("0) выход\n>");
            } while (Switch(int.Parse(Console.ReadLine())));
        }

        static private bool Switch(int key)
        {
            Console.Clear();
            switch (key)
            {
                case 1: new ProgramOne().PlayProgram(); break;
                case 2: new ProgramTwo().PlayProgram(); break;
                case 3: new ProgramThree().PlayProgram(); break;
                case 0: return false;
            }
            return true;
        }
    }
}
