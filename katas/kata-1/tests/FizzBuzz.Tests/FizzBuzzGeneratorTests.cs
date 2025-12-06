using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        public static IEnumerable<object[]> CasosDePruebaFizzBuzz =>
            new List<object[]>
            {
                new object[] { 1, new[] { "1" } },
                new object[] { 2, new[] { "1", "2" } },
                new object[] { 3, new[] { "1", "2", "Fizz" } },
                new object[] { 5, new[] { "1", "2", "Fizz", "4", "Buzz" } },
                new object[] { 15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } }
            };

        [Theory]
        [MemberData(nameof(CasosDePruebaFizzBuzz))]
        public void Generate_ConNumeroValido_DebeRetornarSecuenciaCorrecta(int numero, string[] esperado)
        {
            FizzBuzzGenerator.Generate(numero).Should().BeEquivalentTo(esperado);
        }

        [Fact]
        public void Generate_ConNumeroNegativo_DebeLanzarExcepcion()
        {
            Action act = () => FizzBuzzGenerator.Generate(-1);
            act.Should().ThrowExactly<InvalidOperationException>()
                .WithMessage(FizzBuzzGenerator.ElNumeroNoPuedeSerNegativo);
        }
    }
}