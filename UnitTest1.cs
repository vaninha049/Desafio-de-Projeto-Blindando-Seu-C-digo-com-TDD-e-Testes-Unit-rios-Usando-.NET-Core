using System;
using Xunit;
using New_Talents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora contruirClasse()
        {
            string data = "25/08/2024";
            Calculadora calc = new Calculadora("25/08/2024");
            return calc;
        }
        
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]

        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();
            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]

        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();
            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]

        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();
            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]

        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();
            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]

        public void TestarDivisaoPorZero()
        {
            Calculadora calc = contruirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
                );
        }


        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = contruirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();


            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }


    }
}