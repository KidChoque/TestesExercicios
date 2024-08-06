using Calculos;

namespace CalculoTeste
{
    public class UnitTest1
    {
        //AAA - Arranje:Organização ; Act: Ação ; Assert:Assertir-Certificar 

        [Fact]
        public void TestarMetodoSomar()
        {
            //Arranje 
            var x1 = 5;
            var x2 = 6;
            var valorEsperado = 11;

            //Act
            var soma = Calculo.Somar(x1, x2);

            //Assert
            Assert.Equal(valorEsperado, soma);

        }


       
    }
}