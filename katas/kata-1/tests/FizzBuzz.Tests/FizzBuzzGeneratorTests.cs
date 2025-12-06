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

            string resultado = generator.GenerarFizzBuzz(numero);

            resultado.Should().Be("1");

        }
        [Fact]
        public void Si_Envio2_Debe_devolver1_2( )
        {
            int numero = 2;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.GenerarFizzBuzz(numero);

            resultado.Should().Be("1,2");

        }
        [Fact]
        public void Si_Envio3_Debe_devolver1_2_Fizz( )
        {
            int numero = 3;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.GenerarFizzBuzz(numero);

            resultado.Should().Be("1,2,Fizz");

        }
        [Fact]
        public void Si_Envio5_Debe_devolver1_2_Fizz_4_Buzz( )
        {
            int numero = 5;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.GenerarFizzBuzz(numero);

            resultado.Should().Be("1,2,Fizz,4,Buzz");

        }
        [Fact]
        public void Si_Envio15_Debe_devolver1_2_Fizz_4_Buzz_Fizz_7_8_Fizz_Buzz_11_Fizz_13_14_FizzBuzz()
        {
            int numero = 15;
            var generator = new FizzBuzzGenerator();

            string resultado = generator.GenerarFizzBuzz(numero);

            resultado.Should().Be("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz");

        }
        [Fact]
        public void Si_EnvioNumeroNegativo_Debe_LanzarExcepcion()
        {
            int numero = -1;
            var generator = new FizzBuzzGenerator();

            Action act = () => generator.GenerarFizzBuzz(numero);
 
            act.Should().Throw<ArgumentException>();

            
        }
        
    }
}