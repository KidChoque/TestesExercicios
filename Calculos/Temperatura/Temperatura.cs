    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Temperatura
    {
        public static class Temperatura
        {
            public static float CelciusParaFahrenheit(float celcius)
            {
               var fahrenheit = (celcius * 9 / 5) + 32;

                return fahrenheit;
            }
        }
    }
