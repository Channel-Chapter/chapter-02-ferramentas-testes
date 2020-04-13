using System;
using Xunit;

namespace FerramentasTesteUnidade.Tests.Data
{
    public class ExemploTheoryClassDataTests
    {
        [Theory]
        [ClassData(typeof(VerificaSeSomaImparData))]
        public void Theory_ValidadorNumerico_VerificaSeSomaImpar(int numeroImpar, int numeroPar, bool resultadoEsperado)
        {
            //arrange
            var validadorNumerico = new ValidadorNumerico();

            //act
            var resultadoSoma = validadorNumerico.VerificaSeSomaImpar(numeroImpar, numeroPar);

            //assert
            Assert.Equal(resultadoSoma, resultadoEsperado);
        }
    }
}