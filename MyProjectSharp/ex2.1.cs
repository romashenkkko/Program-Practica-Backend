namespace MyProjectSharp
{
    public class NumberChecker
    {
        public string CheckNumber()
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

        public string ReverseString(string input)
        {
            char[] array_userInput = input.ToCharArray();
            Array.Reverse(array_userInput);
            string reversed_userInput = new string(array_userInput);
            Console.WriteLine($"Actual String is : {input}");
            Console.WriteLine($"Reversed String is : {reversed_userInput}");
            return reversed_userInput;
        }

        public void CheckPerfectSquare(string input)
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
    }
}
