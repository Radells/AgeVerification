using System;

namespace AgeVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            bool CheckName = false;
            bool CheckAge = false;
            bool CheckNumber = false;
            string Name = "", Age = "", Number ="", Parity="", Divisibility = "";
            Console.WriteLine("Пожалуйста, представтесь.");
            while (CheckName == false)
            {
                Console.WriteLine("Как вас зовут? (Имя)");
                Name = Console.ReadLine();
                if (Name.Length > 0)
                {
                    CheckName = true;
                }
            }
            while (CheckAge == false)
            {
                Console.WriteLine("Ваш возраст");
                Age = Console.ReadLine();
                if (Age.Length > 0)
                {
                    CheckAge = true;
                    Parity = CheckParity(Convert.ToInt32(Age));
                }
            }
            Console.WriteLine($"Здарвсвтуйте, {Name}!");
            while (CheckNumber == false)
            {
                Console.WriteLine("Введите цифру от 3 до 9");
                Number = Console.ReadLine();
                if (Number.Length > 0)
                {
                    if (Convert.ToInt32(Number) >= 3 && Convert.ToInt32(Number) <= 9)
                    {
                        CheckNumber = true;
                        Divisibility = CheckDivisibility(Convert.ToInt32(Age), Convert.ToInt32(Number)); 
                    }
                }
            }
            Console.WriteLine($"«{Name}», я проанализировала введённые тобой данные и могу заявить:");
            Console.WriteLine($"1) Твой возраст - {Age} лет, {Parity}");
            Console.WriteLine($"2) Квадратный корень, полученный из твоего возраста - {Math.Round(Math.Sqrt(Convert.ToInt32(Age)), 2)}, {Divisibility} на «{Number}»");
        }
        public static string CheckParity(int Age)
        {
            string Parity;
            if (Convert.ToInt32(Age) % 2 == 1)
            {
                Parity = "Число не четное";
            }
            else
            {
                Parity = "Число четное";
            }
            return Parity;
        }
        public static string CheckDivisibility(int Age, int Number)
        {
            string Divisibility;
            if (Math.Round(Math.Sqrt(Age), 2) % Number == 0)
            {
                Divisibility = "делится без остатка";
            }
            else { Divisibility = "не делится без остатка"; }
            return Divisibility;
        }
    }
}
