using System.Reflection;
using NewTalents.Services;

namespace testNewTalents;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    [InlineData (4, 4, 8)]
    [InlineData (2, 5, 7)]
    [InlineData (3, 7, 10)]
    [InlineData (2, 3, 5)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora  calc = new Calculadora();
        
        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    [InlineData (5, 5, 25)]
    [InlineData (9, 5, 45)]
    [InlineData (2, 5, 10)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        
        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }
   
    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    [InlineData (10, 2, 5)]
    [InlineData (9, 3, 3)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        
        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();
        
        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }
}   