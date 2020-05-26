using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class TypeCoffeeModels
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tipo de Cafe")]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}