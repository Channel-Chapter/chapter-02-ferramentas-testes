using Xunit;

namespace FerramentasTesteUnidade.Tests.Data
{
    public class ExemploFactTests
    {
        [Fact(DisplayName = "Valida numeros impares", Skip = "Teste não será executado")]
        public void Fact_ValidadorNumerico_ValidarNumerosImpares()
        {
            //arrange
            var validadorNumerico = new ValidadorNumerico();

            //act
            var resultado = validadorNumerico.VerificaSeNumeroImpar(9);

            //assert
            Assert.True(resultado);
        }
    }
}