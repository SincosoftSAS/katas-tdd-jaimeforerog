

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string ValidarNumero(int numero)
        {
          
            var resultado = new List<string>();
            for (int i = 1; i <= numero; i++)
            {

                if (i % 15 == 0)
                    resultado.Add("FizzBuzz");
                else if (i % 3 == 0)
                    resultado.Add("Fizz");
                else if (i % 5 == 0)
                    resultado.Add("Buzz");

                else
                    resultado.Add(i.ToString());
            }

            return string.Join(",", resultado);
        }
    }
}