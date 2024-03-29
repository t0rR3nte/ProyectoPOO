using System.ComponentModel.DataAnnotations;
using System;


namespace AgraMarket.Models
{
    public class ComprasModel
    {
        [Key] //Este atributo va a ser la llave
        public long Id { get; set; }
        public long IdCliente { get; set; }

        public string NomProducto { get; set; }

        public int Cantidad { get; set; }

        public DateTime FechaCompra { get; set; }

        public int PrecioProducto { get; set; }

    }
}