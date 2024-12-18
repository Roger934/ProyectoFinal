﻿namespace Gina.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
    }
}
