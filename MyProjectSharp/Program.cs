// using System;

namespace MyProjectSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = CheckNumber();
            string reversed_userInput = ReverseString(userInput);
            CheckPerfectSquare(reversed_userInput);
            string[] names = GetNamesFromUser();
            Dictionary<char, int> lettersCount = CountLetters(names);
            DisplayCharacterCounts(lettersCount);
            
        }

        static string CheckNumber()
        {
            while (true)
            {
                Console.Write("Enter a minimum three digit number: ");
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out _);

                if (isNumber && userInput.Length >= 3)
                {
                    Console.WriteLine($"Your number is {userInput}");
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Your input does not correspond to the condition, try again.");
                }
            }
        }

        static string ReverseString(string input)
        {
            char[] array_userInput = input.ToCharArray();
            Array.Reverse(array_userInput);
            string reversed_userInput = new string(array_userInput);
            Console.WriteLine($"Actual String is : {input}");
            Console.WriteLine($"Reversed String is : {reversed_userInput}");
            return reversed_userInput;
        }

        static void CheckPerfectSquare(string input)
        {
            double numericValue = Convert.ToDouble(input);
            double squareRoot = Math.Sqrt(numericValue);
            if (numericValue % squareRoot == 0)
            {
                Console.WriteLine($"Great, your number from the mirror is a perfect square of {squareRoot}");
            }
            else
            {
                Console.WriteLine("Your number from the mirror is not a perfect square");
            }
        }
        


        static Dictionary<char, int> CountLetters(string[] names)
{
    IDictionary<char, int> countLetters = new Dictionary<char, int>();

    while (true)
    {
        if (names.Length == 3 && CheckNames(names))
        {
            foreach (string name in names)
            {
                foreach (char ch in name.ToLower())
                {
                    if (countLetters.ContainsKey(ch))
                    {
                        countLetters[ch]++;
                    }
                    else
                    {
                        countLetters[ch] = 1;
                    }
                }
            }

            
            break; 
        }
        else
        {
            Console.WriteLine("Your input does not correspond, try again.");
            countLetters.Clear();
        }
    }
     return new Dictionary<char, int>(countLetters);
}



       static bool CheckNames(string[] names){
            foreach(string name in names){
                foreach(char ch in name){
                    if(!char.IsLetter(ch))
                    {
                       Console.WriteLine("One of the names contains invalid characters, please use only letters");
                        return false; 
                    }
                }
                
            }
            return true;
       }



 static void DisplayCharacterCounts(IDictionary<char, int> characterCounts)
        {
            foreach (var pair in characterCounts)
            {
                Console.WriteLine($"The letter '{pair.Key}' appears {pair.Value} times.");
            }
        }

static string[] GetNamesFromUser()
{
    while(true)
    {
        Console.Write("Enter 3 names split by 1 space: ");
        string input = Console.ReadLine();
        string[] names = input.Split(' ');

        if (names.Length == 3 && CheckNames(names))
        {
            return names; 
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter exactly 3 names separated by spaces.");
        }
    }
}
    }
}

