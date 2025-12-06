using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzzGenerator _generator = new();

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "1,2")]
        [InlineData(3, "1,2,Fizz")]
        [InlineData(5, "1,2,Fizz,4,Buzz")]
        [InlineData(15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz")]
        public void GenerarFizzBuzz_ConNumeroValido_DebeRetornarSecuenciaCorrecta(int numero, string esperado)
        {
            string resultado = _generator.GenerarFizzBuzz(numero);

            resultado.Should().Be(esperado);
        }
        [Fact]
        public void Si_EnvioNumeroNegativo_Debe_LanzarExcepcion()
        {
            int numero = -1;

            Action act = () => _generator.GenerarFizzBuzz(numero);

            act.Should().Throw<ArgumentException>();


        }
        
    }
}