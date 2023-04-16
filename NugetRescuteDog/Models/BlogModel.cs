using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetRescuteDog.Models
{
    [Table("RESCUTEBLOG")]
    public class BlogModel
    {
        [Key]
        [Column("IDPOST")]
        public int IdPost { get; set; }
        [Column("TITULO")]
        public string Titulo { get; set; }
        [Column("CONTENIDO")]
        public string Contenido { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
        [Column("IDUSER")]
        public int IdUser { get; set; }
        [Column("FECHA")]
        public string Fecha { get; set; }

    }
}
