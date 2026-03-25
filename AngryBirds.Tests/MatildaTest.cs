using AngryBirds.Biblioteca.Entidades;

public class MatildaTest
{
    [Fact]
    public void Matilda_SinHuevos()
    {
        var matilda = new Matilda();
        matilda.Ira = 10;

        var fuerza = matilda.CalcularFuerza();

        Assert.Equal(20, fuerza);
    }
    
    [Fact]
    public void Matilda_ConHuevos()
    {
        var matilda = new Matilda();
        matilda.Ira = 10;

        matilda.Huevos.Add(new Huevo { Peso = 3 });
        matilda.Huevos.Add(new Huevo { Peso = 2 });

        var fuerza = matilda.CalcularFuerza();

        Assert.Equal(20 + 5, fuerza);
    }
}