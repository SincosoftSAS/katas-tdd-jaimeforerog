using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        [Fact]
        public void Si_Envio1_Debe_devolver1( )
        {
            int numero = 1;

            string resultado=ValidarNumero(numero);

            resultado.Should().Be("1");

        }

        private string ValidarNumero(int numero)
        {
            throw new NotImplementedException();
        }
    }
}