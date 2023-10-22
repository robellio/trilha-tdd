using System.Reflection;
using NewTalents.Services;

namespace testNewTalents;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "20/02/2023";
        Calculadora calc = new Calculadora("20/02/2023");

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    [InlineData (4, 4, 8)]
    [InlineData (2, 5, 7)]
    [InlineData (3, 7, 10)]
    [InlineData (2, 3, 5)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora  calc = construirClasse();
        
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
        Calculadora calc = construirClasse();
        
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
        Calculadora calc = construirClasse();
        
        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();
        
        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
    }
    
    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}   