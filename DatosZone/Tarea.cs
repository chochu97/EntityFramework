namespace DatosZone
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tarea")]
    public partial class Tarea
    {
        public int id { get; set; }

        public DateTime fecha_registro { get; set; }

        [Required]
        public string descripcion_tarea { get; set; }

        public DateTime fecha_tarea { get; set; }
    }
}
