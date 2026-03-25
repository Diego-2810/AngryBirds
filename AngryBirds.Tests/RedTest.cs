using Xunit;
using AngryBirds.Biblioteca.Entidades;

public class RedTest
{
    [Fact]
    public void Red_CalculaFuerzaCorrectamente()
    {
        var red = new Red();
        red.Ira = 2;

        red.Enojarse();

        var fuerza = red.CalcularFuerza();

        Assert.Equal(40, fuerza);
    }
}