using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ePedidoDetalle
    {
        int Id_PedidoDetalle { get; set; }
        int Cantidad { get; set; }
        float SubTotal { get; set; }
        int Id_Hamburgesa { get; set; }
        int Id_Producto { get; set; }
    }
}
