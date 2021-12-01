using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Models
{
    public class Productos
    {
        [Key]
        public int codproducto { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public int cantidad { get; set; }
        public int vencimiento { get; set; }
        public int idcategoria { get; set; }
        public int precio { get; set; }

    }
}
