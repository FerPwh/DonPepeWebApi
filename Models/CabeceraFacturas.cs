using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Models
{
    public class CabeceraFacturas
    {
        [Key]
        public int nrofactura { get; set; }
        public DateTime fecha { get; set; }
        public int total { get; set; }
        public int idcliente { get; set; }
    }
}
