using Xunit;

namespace DemoApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Soma_DeveRetornarValorCorreto()
    {
        // Arrange
        var a = 2;
        var b = 3;
        // Act
        var resultado = a + b;

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Soma_NaoDeveRetornarValorErrado()
    {
        var a = 2;
        var b = 2;

        Assert.NotEqual(5, a + b);
    }
}
