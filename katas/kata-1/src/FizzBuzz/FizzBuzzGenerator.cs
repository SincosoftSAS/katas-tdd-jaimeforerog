

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private const int MULTIPLO_FIZZ = 3;
        private const int MULTIPLO_BUZZ = 5;
        private const string PALABRA_FIZZ = "Fizz";
        private const string PALABRA_BUZZ = "Buzz";

        public string GenerarFizzBuzz(int numero)
        {
            if (numero < 0)
                throw new ArgumentException("El número no puede ser negativo", nameof(numero));

            var valoresFizzBuzz = new List<string>();

            for (int i = 1; i <= numero; i++)
            {
                valoresFizzBuzz.Add(ObtenerValorFizzBuzz(i));
            }

            return string.Join(",", valoresFizzBuzz);
        }
        private string ObtenerValorFizzBuzz(int numero)
        {
            var resultado = "";
            if (numero % MULTIPLO_FIZZ == 0) resultado += PALABRA_FIZZ;
            if (numero % MULTIPLO_BUZZ == 0) resultado += PALABRA_BUZZ;
            return string.IsNullOrEmpty(resultado) ? numero.ToString() : resultado;
        }
    }
}