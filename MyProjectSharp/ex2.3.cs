namespace MyProjectSharp
{
    public class NameAnalyzer
    {
        public string[] GetNamesFromUser()
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

        public Dictionary<char, int> CountLetters(string[] names)
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

        public void DisplayCharacterCounts(IDictionary<char, int> characterCounts)
        {
             foreach (var pair in characterCounts)
            {
                Console.WriteLine($"The letter '{pair.Key}' appears {pair.Value} times.");
            }
        }

        private bool CheckNames(string[] names)
        {
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
    }
}
