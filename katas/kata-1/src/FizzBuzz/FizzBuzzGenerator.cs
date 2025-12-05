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
                if (i % 3 == 0)
                    resultado += "Fizz,";
                else
                    resultado += i.ToString()+',';

            }
            return resultado.TrimEnd(',');
        }
    }
}  