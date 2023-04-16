using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetRescuteDog.Models
{
    [Table("COMENTARIOS")]
    public class Comentario
    {
        [Key]
        [Column("IDCOMENTARIO")]
        public int IdComentario { get; set; }
        [Column("IDPOST")]
        public int IdPost { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("COMENTARIOTEXT")]
        public string ComentarioDesc { get; set; }
        [Column("FECHA")]
        public string Fecha { get; set; }
        [Column("IDUSER")]
        public int IdUser { get; set; }

    }
}
