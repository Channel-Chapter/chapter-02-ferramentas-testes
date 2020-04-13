using System.Collections.Generic;
using Xunit;

namespace FerramentasTesteUnidade.Tests
{
    public class ExemploTheoryMemberDataTests
    {
        [Theory]
        [MemberData(nameof(CenariosClienteEmailEnviarEmail))]
        public void ClienteEmail_Deve_ValidarEmailParaEnvio(Email email, ResultadoEnvioEmail resultadoEnvioEmail)
        {
            var clienteEmail = new ClienteEmail();

            var emailEnviado = clienteEmail.ValidaEmailParaEnvio(email);

            Assert.Equal(emailEnviado.Enviado, resultadoEnvioEmail.Enviado);
            Assert.Equal(emailEnviado.Mensagem, resultadoEnvioEmail.Mensagem, ignoreCase: true);
        }

        #region Dados de Entrada

        public static IEnumerable<object[]> CenariosClienteEmailEnviarEmail()
        {
            // parametros para envio com sucesso
            yield return new object[]
            {
                    new Email { Conteudo = "Teste Unitário", Destinatario = "chapter@zup.com"},
                    new ResultadoEnvioEmail { Enviado = true, Mensagem = "sucesso" }
            };

            // parametros para envio com falha
            yield return new object[]
            {
                new Email { Conteudo = "Email Errado", Destinatario = "email-invalido!!"},
                new ResultadoEnvioEmail { Enviado = false, Mensagem = "falha"}
            };

            // parametros para envio com falha
            yield return new object[]
            {
                new Email { Conteudo = null, Destinatario = "email@valido.com"},
                new ResultadoEnvioEmail { Enviado = false, Mensagem = "falha"}
            };
        }

        #endregion Dados de Entrada
    }
}