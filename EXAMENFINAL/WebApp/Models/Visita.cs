namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visita")]
    public partial class Visita
    {
        [StringLength(30)]
        public string Motivo_visita { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime? Fecha_visita { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? Hora_entrada { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? Hora_salida { get; set; }

        [StringLength(30)]
        public string Nombre_completo { get; set; }

        [StringLength(30)]
        public string Contacto_recibio { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Visitas { get; set; }
    }
}
