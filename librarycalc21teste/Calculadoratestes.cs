using librarycalc21;
using System;
using Xunit;

namespace librarycalc21teste
{
    public class Calculadoratestes
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(11, 25)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(0, 12)]
        [InlineData(112,02)]

        public void somasucesso(int x, int y)
        {
            var calculadora = new calculadora();
            
         

            var resultado = calculadora.somar(x, y);

            Assert.True((x + y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(11, 25)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(0, 12)]
        [InlineData(112, 02)]

        public void subtraçãosucesso(int x, int y)
        {
            var calculadora = new calculadora();

            var resultado = calculadora.subtrair(x, y);

            Assert.True((x - y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(11, 25)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(0, 12)]
        [InlineData(112, 02)]

        public void multiplicaçaosucesso(int x, int y)
        {
            var calculadora = new calculadora();

            var resultado = calculadora.multiplicar(x, y);

            Assert.True((x * y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(11, 25)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(0, 12)]
        [InlineData(112, 02)]

        public void divisãosucesso(double x, double y)
        {
            var calculadora = new calculadora();
            var resultado = calculadora.dividir(x, y);

            Assert.True((x / y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(11, 25)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(0, 12)]
        [InlineData(112, 02)]
        
        public void somaError(int x, int y)
        {
            var calculadora = new calculadora();
            var resultado = calculadora.somar(x, y);

            Assert.False((x + y) != resultado);
        }



       
    }
}
