using Livros;

namespace TesteLivros
{
    public class TesteLivros
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Livros.Livros.Listalivros.Clear();
            var livro1 = "";
            
            //Act
            List<string> livros = Livros.Livros.AdicionarLivro(livro1);

            //Assert
            Assert.Contains(livro1, livros);
            Assert.Equal(1, livros.Count);

        }
    }
}