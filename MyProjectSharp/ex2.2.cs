namespace MyProjectSharp
{
    public class NumberListProcessor
    {
        public double[] GetListFromUser()
        {
            Console.Write("Enter a list of numbers: ");
            string inputList = Console.ReadLine();
            string[] numbers = inputList.Split(' ');
            double[] arr_ofnumbers = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (double.TryParse(numbers[i], out double number))
                {
                    arr_ofnumbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"'{numbers[i]}' is not a valid number.");
                }
            }
            return arr_ofnumbers;
        }

        public void DisplayNumereCuZecimi(double[] arr_ofnumbers)
        {
             Console.WriteLine("Numerele care NU sunt intregi: ");
            foreach (double num in arr_ofnumbers)
            {
                if (num % 1 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public double FindTheSmallest(double[] arr_ofnumbers)
        {
           double smallest = double.MaxValue;
            foreach (double num in arr_ofnumbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
        }
    }
}
