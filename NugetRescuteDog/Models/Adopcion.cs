using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetRescuteDog.Models
{
    [Table("ADOPCION")]
    public class Adopcion
    {
        [Key]
        [Column("IDMASCOTA")]
        public int IdMascota { get; set; }
        [Column("IDUSER")]
        public int IdUser { get; set; }
        [Column("Fecha_Adopcion")]
        public DateTime FechaAdopcion { get; set; }
    }
}
