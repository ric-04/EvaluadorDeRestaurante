using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EvaluadorDeRestaurante.Models
{
    public class Restaurante
    {
        [Key]
        public int IdRestaurante { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Nota { get; set; }
    }

    public class RestauranteDbContext : DbContext
    {
        public DbSet<Restaurante> Restaurantes { get; set; }
    }
}