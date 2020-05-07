using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class ProductModels
    {
        [Key]
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SupplirId { get; set; }

        [ForeignKey("SupplirId")]
        public virtual SupplierModels Supplir { get; set; }

        /*
            Id
            ProductCode
            ProductName
            Description
            Quantity
            Price
            SupplirId (vincular como llave foranea)
         */
    }
}