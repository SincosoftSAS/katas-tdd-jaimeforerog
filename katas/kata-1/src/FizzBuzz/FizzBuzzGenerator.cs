using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string ValidarNumero(int numero)
        {
            var resultado = "";
            for (int i = 1; i <= numero; i++)
            {
                if (i % 15 == 0)
                    resultado += "FizzBuzz,";
                else if (i % 3 == 0)
                    resultado += "Fizz,";
                else if (i % 5 == 0)
                    resultado += "Buzz,";

                else
                    resultado += i.ToString() + ',';
            }

            return resultado.TrimEnd(',');
        }
    }
}