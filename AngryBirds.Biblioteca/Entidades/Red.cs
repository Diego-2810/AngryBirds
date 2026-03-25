using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngryBirds.Biblioteca.Entidades;

namespace AngryBirds.Biblioteca.Entidades;

public class Red : Pajaro
{
    public int VecesEnojado { get; set; }
    public override void Enojarse()
    {
        base.Enojarse();
        VecesEnojado++;
    }
    public override int CalcularFuerza()
    {
        return Ira* 10 * VecesEnojado;
    }
}
