using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public class Chuck : Pajaro
{
    public int Velocidad { get; set; }
    public override int CalcularFuerza()
    {
        if (Velocidad <= 80)
            return 150;

        return 150 + (Velocidad - 80) * 5;
    }

    public override void Enojarse()
    {
        Velocidad *= 2;
    }
}
