using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class OrdersModels
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre y Apellido")]
        [MaxLength(80)]
        public string Name { get; set; }

        public DateTime? DateOrder { get; set; }
        public int Cantidad { get; set; }
        public int StatusOrderNameId { get; set; }
        

        /*Other ForeignKey*/

        [ForeignKey("StatusOrderNameId")]
        public StatusOrderNameModels StatusOrderName { get; set; }


        public int CoffeeId { get; set; }
        [ForeignKey("CoffeeId")]
        public CoffeeModels Coffee { get; set; }


    }
}