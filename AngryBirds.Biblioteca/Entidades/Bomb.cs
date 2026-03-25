using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public class Bomb : Pajaro
{
    public int TopeFuerza { get; set; } = 9000;
    public override int CalcularFuerza()
    {
        int fuerza = Ira * 2;
        if (fuerza > TopeFuerza)
        {
            return TopeFuerza;
        }
        return fuerza;

    }
    
}
