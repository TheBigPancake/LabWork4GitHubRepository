using System;

namespace LabWork4GitHubRepository
{
    class Program
    {
        private static RunebleClass[] classes = { };
        static void Main(string[] args)
        {
            Menu();
        }

        static private void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Работа с удаленными репозиториями\nВыбирете сообщение:");
                Console.WriteLine("\t1) Сообщение Городенского Станислава");
                Console.Write("\t0) выход\n>");
            } while (Switch(int.Parse(Console.ReadLine())));
        }

        static private bool Switch(int key)
        {
            Console.Clear();
            if (key == 0) 
                return false;
            classes[key - 1].Run();
            return true;
        }
    }
}
