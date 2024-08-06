namespace TesteTemperatura
{
    public class TemperaturaTests
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(-40, -40)]
  
        public void Teste1(float celcius, float Fahrenheit)
        {
            // Act
            float convercao = Temperatura.Temperatura.CelciusParaFahrenheit(celcius);

            // Assert
            Assert.Equal(Fahrenheit, convercao, precision: 2);
        }
    }
}