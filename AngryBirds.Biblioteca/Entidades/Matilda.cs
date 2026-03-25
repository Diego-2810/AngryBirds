using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public class Matilda : Pajaro
{
    public List<Huevo> Huevos { get; set; } = new List<Huevo>();
    public override int CalcularFuerza()
    {
        int fuerzaHuevos = Huevos.Sum(h => h.CalcularFuerza());
        return Ira * 2 + fuerzaHuevos;
    }

    public override void Enojarse()
    {
        base.Enojarse();
        Huevos.Add(new Huevo { Peso = 2 });
    }
}
