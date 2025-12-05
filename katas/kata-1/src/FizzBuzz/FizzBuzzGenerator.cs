using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzGenerator   
    {
        public string ValidarNumero(int numero)
        {
            if (numero == 2)
                return "1,2";
            return "1";
        }
    }
}