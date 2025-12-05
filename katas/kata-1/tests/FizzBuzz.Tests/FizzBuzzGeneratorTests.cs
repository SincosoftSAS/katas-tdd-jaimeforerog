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
        [Fact]
        public void Si_Envio2_Debe_devolver1_2( )
        {
            int numero = 2;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.ValidarNumero(numero);

            resultado.Should().Be("1,2");

        }
        [Fact]
        public void Si_Envio3_Debe_devolver1_2_Fizz( )
        {
            int numero = 3;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.ValidarNumero(numero);

            resultado.Should().Be("1,2,Fizz");

        }
        [Fact]
        public void Si_Envio5_Debe_devolver1_2_Fizz_4_Buzz( )
        {
            int numero = 5;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.ValidarNumero(numero);

            resultado.Should().Be("1,2,Fizz,4,Buzz");

        }
        
    }
}