using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
    
        public int Id { get; set; }
        [Display(Name = "Codigo Proveedor")]
        [Required]
        [MaxLength(10)]
        [StringLength(100, ErrorMessage = "El {0} debe tener un largo de  {1} caracteres.")]
        public string SupplierCode { get; set; }
        [Required]
        [Display(Name ="Proveedor")]
        [MaxLength(150)]
        public string SupplierName { get; set; }
        [Display(Name ="Correo Electrónico")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Display(Name ="Telefono")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Display(Name ="Dirección")]
        public string Address { get; set; }

    }
}