using Emails;

namespace TesteEmail
{
    public class TesteEmail
    {
        [Theory]
        [InlineData("wandinho@gmail.com",true)]
        [InlineData("rubao.com",true)]

        public void TesteVerificacaoEmail(string email,bool verificado)
        {
            bool verificacao = Email.VerificarEmail(email);

            Assert.Equal(verificado, verificacao);
        }
    }
}