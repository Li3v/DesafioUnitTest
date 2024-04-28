using System.Globalization;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _Calc;
    public CalculadoraTestes()
    {
        _Calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10eRetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _Calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSubtrair10com10eRetornar0()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _Calc.subtrair(num1, num2);

        //Assert
        Assert.Equal(0, resultado);
    }
    [Fact]
    public void DeveMultiplicar10com5eRetornar50()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int resultado = _Calc.multiplicar(num1, num2);

        //Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DeveDividirNum1ENum2RetornarResultado()
    {
        int num1 = 10;
        int num2 = 2;
        //Act
        int resultado = _Calc.dividir(num1, num2);

        //Assert
        Assert.Equal(5, resultado);
    }


}