using MyProjectSharp;

class Program
{
    static void Main(string[] args)
    {
        NumberChecker numberChecker = new NumberChecker();
        string userInput = numberChecker.CheckNumber();
        string reversed_userInput = numberChecker.ReverseString(userInput);
        numberChecker.CheckPerfectSquare(reversed_userInput);

        NameAnalyzer nameAnalyzer = new NameAnalyzer();
        string[] names = nameAnalyzer.GetNamesFromUser();
        Dictionary<char, int> lettersCount = nameAnalyzer.CountLetters(names);
        nameAnalyzer.DisplayCharacterCounts(lettersCount);

        NumberListProcessor numberListProcessor = new NumberListProcessor();
        double[] arr_ofnumbers = numberListProcessor.GetListFromUser();
        numberListProcessor.DisplayNumereCuZecimi(arr_ofnumbers);
        double smallestNumber = numberListProcessor.FindTheSmallest(arr_ofnumbers);
        Console.WriteLine($"The smallest number is: {smallestNumber}");
    }
}
