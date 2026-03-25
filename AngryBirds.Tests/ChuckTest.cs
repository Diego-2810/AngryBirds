using Xunit;
using AngryBirds.Biblioteca.Entidades;

public class ChuckTest
{
    [Fact]
    public void Chuck_FuerzaHasta80()
    {
        var chuck = new Chuck();
        chuck.Velocidad = 50;

        var fuerza = chuck.CalcularFuerza();

        Assert.Equal(150, fuerza);
    }

    [Fact]
    public void Chuck_FuerzaMayorA80()
    {
        var chuck = new Chuck();
        chuck.Velocidad = 100;

        var fuerza = chuck.CalcularFuerza();

        Assert.Equal(150 + (20 * 5), fuerza);
    }

    [Fact]
    public void Chuck_SeEnojaDuplicaVelocidad()
    {
        var chuck = new Chuck();
        chuck.Velocidad = 50;

        chuck.Enojarse();

        Assert.Equal(100, chuck.Velocidad);
    }
}