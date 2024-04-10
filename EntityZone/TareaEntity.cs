using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityZone
{
    public class TareaEntity
    {
        public int Id { get; set; } 
        public DateTime FechaRegistro { get; set; }
        public string Descripcion {  get; set; }
        public DateTime FechaLimite { get; set; }

    }
}
