namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (input == "")
                return 0;
           
            var values = input.Split(',');
            var total = 0;
            
            foreach (var value in values)
            {
                total += int.Parse(value);
            }
            return total;
        }
    }
}