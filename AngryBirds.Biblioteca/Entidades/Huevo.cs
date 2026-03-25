using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public class Huevo
{
    public int Peso { get; set; }
    public int CalcularFuerza()
    {
        return Peso;
    }
}
