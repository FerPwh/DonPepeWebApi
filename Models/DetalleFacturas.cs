using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Models
{
    public class DetalleFacturas
    {
        [Key]
        public int nrofactura { get; set; }
        [Key]
        public int linea { get; set; }
        public int codproducto { get; set; }
        public int cantidad{ get; set; }
        public int total { get; set; }
    }
}
