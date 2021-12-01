using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Models
{
    public class Categorias
    {
        [Key]
        public int idcategoria { get; set; }
        public string nombre { get; set; }
    }
}
