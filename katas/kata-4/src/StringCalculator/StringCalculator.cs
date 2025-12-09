namespace StringCalculator
{
    public class Calculator
    {
        private const int MaxNumber = 1000;

        public static int Calculate(string input)
        {
            if (input == "")
                return 0;

            input = ExtractDelimiter(input);

            input = input.Replace("\n", ",");

            var values = input.Split(',');
            var numbers = ParseNumbers(values);
            ValidateNoNegatives(numbers);

            return SumValidNumbers(numbers);
        }

        private static string ExtractDelimiter(string input)
        {
            if (input.StartsWith("//"))
            {
                var delimiterEndIndex = input.IndexOf('\n');
                var delimiterPart = input.Substring(2, delimiterEndIndex - 2);

                string delimiter;
                if (delimiterPart.StartsWith("[") && delimiterPart.EndsWith("]"))
                {
                    delimiter = delimiterPart.Substring(1, delimiterPart.Length - 2);
                }
                else
                {
                    delimiter = delimiterPart;
                }

                input = input.Substring(delimiterEndIndex + 1);
                input = input.Replace(delimiter, ",");
            }

            return input;
        }

        private static int SumValidNumbers(List<int> numbers)
        {
            return numbers
                .Where(n => n >= 0)
                .Select(n => n > MaxNumber ? 0 : n)
                .Sum();
        }

        private static void ValidateNoNegatives(List<int> numbers)
        {
            var negatives = numbers.Where(n => n < 0).ToList();
            if (negatives.Count > 0)
            {
                var negativesString = string.Join(",", negatives);
                throw new ArgumentOutOfRangeException(null, $"Negativos no permitidos {negativesString}");
            }
        }

        private static List<int> ParseNumbers(string[] values)
        {
            var numbers = new List<int>();
            foreach (var value in values)
            {
                numbers.Add(int.Parse(value));
            }

            return numbers;
        }
    }
}