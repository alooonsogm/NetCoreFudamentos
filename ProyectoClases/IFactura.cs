using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public interface IFactura
    {
        //Solo tiene estructura de declaracion de elementos.
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }
        void CalcularIva();
        void OdioHacienda(int mucho);
    }
}
