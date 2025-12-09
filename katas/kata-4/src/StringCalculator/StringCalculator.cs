namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (input == "")
                return 0;
            
            
            if (input.StartsWith("//"))
            {
                var delimiterEndIndex = input.IndexOf('\n');
                var delimiter = input.Substring(2, delimiterEndIndex - 2);
                input = input.Substring(delimiterEndIndex + 1);
                input = input.Replace(delimiter, ",");
            }

            input = input.Replace("\n", ",");

            var values = input.Split(',');
            var negatives = new List<int>();
            var total = 0;

            foreach (var value in values)
            {
                var number = int.Parse(value);
                if (number < 0)
                {
                    negatives.Add(number);
                }
                else
                {
                    total += number;
                }
            }

            if (negatives.Count > 0)
            {
                var negativesString = string.Join(",", negatives);
                throw new ArgumentOutOfRangeException(null, $"Negativos no permitidos {negativesString}");
            }

            return total;
        }
    }
}