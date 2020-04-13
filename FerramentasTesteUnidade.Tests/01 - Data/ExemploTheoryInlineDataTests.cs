using System;
using Xunit;

namespace FerramentasTesteUnidade.Tests.Data
{
    public class ExemploTheoryInlineDataTests
    {
        #region Teoria de dados

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void Theory_ValidadorNumerico_VerificaSeNumeroImpar(int numeroImpar)
        {
            //arrange
            var validadorNumerico = new ValidadorNumerico();

            //act
            var resultadoImpar = validadorNumerico.VerificaSeNumeroImpar(numeroImpar);

            //assert
            Assert.True(resultadoImpar);
        }

        #endregion Teoria de dados

        #region Teoria de dados por resultado

        [Theory]
        [InlineData(1, 2, true)]
        [InlineData(3, 3, false)]
        [InlineData(5, 4, true)]
        [InlineData(7, 7, false)]
        [InlineData(9, 10, true)]
        public void Theory_ValidadorNumerico_VerificaSeSomaImpar(int primeiroNumero, int segundoNumero, bool resultadoEsperado)
        {
            //arrange
            var validadorNumerico = new ValidadorNumerico();

            //act
            var resultadoSoma = validadorNumerico.VerificaSeSomaImpar(primeiroNumero, segundoNumero);

            //assert
            Assert.Equal(resultadoSoma, resultadoEsperado);
        }

        #endregion Teoria de dados por resultado
    }
}