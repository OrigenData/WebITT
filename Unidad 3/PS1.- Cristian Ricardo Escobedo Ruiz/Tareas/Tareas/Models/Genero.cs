using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tareas.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string NomGenero { get; set; }
    }
}