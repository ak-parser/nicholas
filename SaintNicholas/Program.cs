using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SaintNicholas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Gift> gifts = new List<Gift>();

                Nicholas nicholas = Nicholas.Instance;
                nicholas.Wishes = new WishManager(new List<string>() { "Be strong", "Be happy", "Be cheerful", "Be healthy" }, 
                    new List<string>() { "Be beatiful", "Be happy", "Be clever", "Be healthy" });

                int childrenCount;
                do
                    Console.Write("Enter number of children: ");
                while (!Int32.TryParse(Console.ReadLine(), out childrenCount) || childrenCount < 0);

                bool ignoreBadActions;
                do
                    Console.Write("Ignore bad actions? (true | false): ");
                while (!bool.TryParse(Console.ReadLine(), out ignoreBadActions));

                for (int i = 0; i < childrenCount; i++)
                {
                    Console.WriteLine($"Child №{i + 1}");
                    string name;
                    int goodActions, badActions;
                    Gender gender;

                    do
                        Console.Write("Enter child's name: ");
                    while (!Regex.IsMatch(name = Console.ReadLine(), @"^[A-Za-z]+$"));

                    do
                        Console.Write("Enter child's gender: (Male | Female): ");
                    while (!Enum.TryParse(Console.ReadLine(), out gender) || !Enum.IsDefined(typeof(Gender), gender));

                    do
                        Console.Write("Enter child's number of good actions: ");
                    while (!Int32.TryParse(Console.ReadLine(), out goodActions) || goodActions < 0);

                    do
                        Console.Write("Enter child's number of bad actions: ");
                    while (!Int32.TryParse(Console.ReadLine(), out badActions) || badActions < 0);

                    Child child = new Child(name, gender, goodActions, badActions);
                    gifts.Add(nicholas.GiveGift(child, ignoreBadActions));
                }

                Console.WriteLine("\nGifts:");
                foreach (Gift elem in gifts)
                    Console.WriteLine(elem);

            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
