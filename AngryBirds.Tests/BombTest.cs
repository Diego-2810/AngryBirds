using AngryBirds.Biblioteca.Entidades;

public class BombTest
{
    [Fact]
    public void Bomb_NoSuperaTope()
    {
        var bomb = new Bomb();
        bomb.Ira = 5000; // 10000 de fuerza

        var fuerza = bomb.CalcularFuerza();

        Assert.Equal(9000, fuerza);
    }

    [Fact]
    public void Bomb_RespetaTopeConfigurado()
    {
        var bomb = new Bomb();
        bomb.Ira = 1000;
        bomb.TopeFuerza = 1500;

        var fuerza = bomb.CalcularFuerza();

        Assert.Equal(1500, fuerza);
    }
}