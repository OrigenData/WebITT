using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class SupplierModels
    {
        [Key]
        public int id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        /*
            SupplierCode
            SupplierName
            Email
            Phone
            Address
         */

    }
}
 