using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tareas.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Resumen { get; set; }
        public string UrlImagen { get; set; }
        public int GeneroId { get; set; }
        
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

    }
}