namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private const int MultiploFizz = 3;
        private const int MultiploBuzz = 5;
        private const string PalabraFizz = "Fizz";
        private const string PalabraBuzz = "Buzz";
        private const string Separador = ",";
        public const string ElNumeroNoPuedeSerNegativo = "El número no puede ser negativo.";

        public string GenerarFizzBuzz(int numero)
        {
            ValidarNumero(numero);

            var valoresFizzBuzz = new List<string>(numero);

            for (int i = 1; i <= numero; i++)
            {
                valoresFizzBuzz.Add(ObtenerValorFizzBuzz(i));
            }

            return string.Join(Separador, valoresFizzBuzz);
        }

        private void ValidarNumero(int numero)
        {
            if (numero < 0)
                throw new InvalidOperationException(ElNumeroNoPuedeSerNegativo );
        }

        private string ObtenerValorFizzBuzz(int numero)
        {
            var resultado = "";
            if (numero % MultiploFizz == 0) resultado += PalabraFizz;
            if (numero % MultiploBuzz == 0) resultado += PalabraBuzz;
            return resultado.Length > 0 ? resultado : numero.ToString();
        }
    }
}