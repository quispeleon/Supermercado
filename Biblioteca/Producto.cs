using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotecaa
{
class Producto
{
    required public string Nombre { get; set; }
    public decimal PrecioUnitario { get; set; }
    public int Cantidad { get; set; }

    public override string ToString()  //ToString(): sobrescribe el método que convierte el objeto a texto ,
    //  mostrando sus datos de forma legible.
    {
        return $"Nombre: {Nombre}, Precio: {PrecioUnitario}, Cantidad: {Cantidad}";
    }
}
}