using Inventarios;

namespace TesteInventario
{
    public class UnitTest1
    {
        [Fact]
        public static void TestMethodAddProduct()
        {
            string produto = "Prato";

            int qtde1 = 90;
            Inventario.AdicionarProduto(produto, qtde1);

            int qtde2 = 9;
            Inventario.AdicionarProduto(produto, qtde2);

            int totalQtde = Inventario.ContarProdutos(produto);

            Assert.Equal(qtde1 + qtde2, totalQtde);
        }
    }
}
}