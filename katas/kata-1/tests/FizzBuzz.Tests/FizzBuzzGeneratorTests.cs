using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        private readonly FizzBuzzGenerator _generator = new();

        public static IEnumerable<object[]> CasosDePruebaFizzBuzz =>
            new List<object[]>
            {
                new object[] { 1, "1" },
                new object[] { 2, "1,2" },
                new object[] { 3, "1,2,Fizz" },
                new object[] { 5, "1,2,Fizz,4,Buzz" },
                new object[] { 15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz" }
            };

        [Theory]
        [MemberData(nameof(CasosDePruebaFizzBuzz))]
        public void GenerarFizzBuzz_ConNumeroValido_DebeRetornarSecuenciaCorrecta(int numero, string esperado)
        {
            _generator.GenerarFizzBuzz(numero).Should().Be(esperado);
        }

        [Fact]
        public void GenerarFizzBuzz_ConNumeroNegativo_DebeLanzarExcepcion()
        {
            Action act = () => _generator.GenerarFizzBuzz(-1);
            act.Should().ThrowExactly<InvalidOperationException>().WithMessage("El número no puede ser negativo.");
        }
    }
}