namespace FerramentasTesteUnidade.Tests.Data
{
    public class ValidadorNumerico
    {
        public bool VerificaSeNumeroImpar(int numero)
        {
            return numero % 2 != 0;
        }

        public bool VerificaSeSomaImpar(int primeiroValor, int segundoValor)
        {
            return (primeiroValor + segundoValor) % 2 != 0;
        }
    }
}