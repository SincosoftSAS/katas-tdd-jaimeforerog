using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Si_Envio1_Debe_devolver1( )
        {
            int numero = 1;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.ValidarNumero(numero);

            resultado.Should().Be("1");

        }

     
    }
}