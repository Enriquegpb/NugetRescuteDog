using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetRescuteDog.Models
{
    [Table("REFUGIOS")]
    public class Refugio
    {
        [Key]
        [Column("IDREFUGIO")]
        public int IdRefugio { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("LOCALIDAD")]
        public string Localidad { get; set; }
        [Column("UBICACION")]
        public string Ubicacion { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
        [Column("VALORACION")]
        public int Valoracion { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

    }
}
