using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class CoffeeModels
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Display(Name = "Información nutricional")]
        public string NutritionInformation { get; set; }

        [Display(Name = "Ingredientes")]
        [MaxLength(50)]
        public string Ingredients { get; set; }

        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Tipo de Cafe")]
        public int TypeCoffeeId { get; set; }


        /*Other Key F*/
        [ForeignKey("TypeCoffeeId")]
        public TypeCoffeeModels TypeCoffee { get; set; }

        [Display(Name = "Imagen URL")]
        public string ImagenCoffee { get; set; }
    }
}