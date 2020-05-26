using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class StatusOrderNameModels
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Estatus")]
        [MaxLength(50)]
        public string StatusName { get; set; }
    }
}