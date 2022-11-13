using health_calc_pack_dotnet;
using Xunit;

namespace health_calc_test_xunit
{
    public class IMCTest
    {
        [Fact]
        public void testarRequisicaoIMCComDadosValidos()
        {
            var imc = new IMC();
            var altura = 1.83;
            var peso = 58;
            var imcEsperado = 17.32;

            var imcCalculado = imc.CalcularIMC(altura, peso);

            Assert.Equal(imcEsperado, imcCalculado);
        }

        [Fact]
        public void testarRequisicaoIMCComDadosEmRange()
        {
            var imc = new IMC();
            var altura = 1.83;
            var peso = 58;
            var imcEsperadoMin = 17.30;
            var imcEsperadoMax = 17.40;

            var imcCalculado = imc.CalcularIMC(altura, peso);

            Assert.InRange(imcCalculado, imcEsperadoMin, imcEsperadoMax);
        }

        [Fact]
        public void testarRequisicaoIMCComDadosInvalidos()
        {
            var imc = new IMC();
            var altura = 0.00;
            var peso = 0.00;

            Assert.Throws<Exception>(() => imc.CalcularIMC(altura, peso));
        }

        [Theory]
        [InlineData(17.5, "Abaixo do peso")]
        [InlineData(18.49, "Abaixo do peso")]
        [InlineData(18.5, "Peso normal")]
        [InlineData(24.99, "Peso normal")]
        [InlineData(25, "Pré-obesidade")]
        [InlineData(29.99, "Pré-obesidade")]
        [InlineData(30, "Obesidade Grau I")]
        [InlineData(34.99, "Obesidade Grau I")]
        [InlineData(35, "Obesidade Grau II")]
        [InlineData(39.99, "Obesidade Grau II")]
        [InlineData(40, "Obesidade Grau III")]
        [InlineData(45, "Obesidade Grau II")]
        public void testarRetornCategoriaIMC(double IMC, string ResultadoEsperado)
        {
            var imcClass = new IMC();

            var Resultado = imcClass.RetornarClassificacaoIMC(IMC);

            Assert.Equal(ResultadoEsperado, ResultadoEsperado);
        }

    }
}