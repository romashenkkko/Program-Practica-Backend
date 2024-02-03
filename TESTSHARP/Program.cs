using System;
using System.Collections.Generic;

namespace MyProjectSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<char, int> countLetters = new Dictionary<char, int>();
            

            while (true)
            {
                Console.Write("Enter 3 names split by 1 space: ");
                string userInput = Console.ReadLine();
                string[] names = userInput.Split(' ');


                if (names.Length == 3 && CheckNames(names))
                {

                    foreach (string name in names)
                    {
                        foreach (char ch in name.ToLower())
                        {
                            
                            bool isLetter = Char.IsDigit(ch);
                            if (countLetters.ContainsKey(ch))
                            {
                                countLetters[ch]++;
                            }
                            if (!countLetters.ContainsKey(ch))
                            {
                                countLetters[ch] = 1;
                            }
                        }
                    }

                    foreach (var pair in countLetters)
                    {
                        Console.WriteLine($"Caracterul '{pair.Key}' apare de {pair.Value} ori.");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Your input does not correspond, try again.");
                    
                    countLetters.Clear();
                }
            }
        }

        static bool CheckNames(string[] names){
            foreach(string name in names){
                foreach(char ch in name){
                    if(!char.IsLetter(ch))
                    {
                       Console.WriteLine("One of the names contains invalid characters. Please use only letters.");
                        return false; 
                    }
                }
            }
            return true; 
        }
    }
}
