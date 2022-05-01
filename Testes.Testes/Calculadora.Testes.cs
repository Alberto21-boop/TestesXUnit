using Xunit;

namespace Calculadora.Testes
{
    public class CalculadoraTestes
    {
        [Fact]
        public void DeveSomar10Mais10Retornando20()
        {
            var result = new Calculadora();
            Assert.Equal(20, result.DeveSomar10Mais10Retornando20(10, 10));
        }
    }
}