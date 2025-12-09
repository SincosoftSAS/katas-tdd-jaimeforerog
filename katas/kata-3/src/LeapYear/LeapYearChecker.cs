namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 0)
                throw new ArgumentOutOfRangeException(nameof(year), "Year cannot be negative"); 
            if (year >= 4000)
                throw new ArgumentOutOfRangeException(nameof(year), "Year cannot be mayor that 4000 years");
            
            if (year % 100 == 0 && year % 400 != 0)
                return false; 
            if (year % 4 == 0 )
                return true;

            return false;
        }
    }
}