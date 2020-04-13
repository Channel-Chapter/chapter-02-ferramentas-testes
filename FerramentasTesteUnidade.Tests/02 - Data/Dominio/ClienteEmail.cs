using System.Text.RegularExpressions;

namespace FerramentasTesteUnidade.Tests
{
    public class ClienteEmail
    {
        public ResultadoEnvioEmail ValidaEmailParaEnvio(Email email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            bool emailValido = regex.Match(email.Destinatario).Success;
            bool possuiConteudo = !string.IsNullOrEmpty(email.Conteudo);

            if (emailValido && possuiConteudo)
            {
                return new ResultadoEnvioEmail() { Enviado = true, Mensagem = "sucesso" };
            }
            else
            {
                return new ResultadoEnvioEmail() { Enviado = false, Mensagem = "falha" };
            }
        }
    }
}