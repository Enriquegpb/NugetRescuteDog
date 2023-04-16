using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetRescuteDog.Models
{
    [Table("USERS_VOLUNTARIOS")]
    public class User
    {
        [Key]
        [Column("IDUSER")]
        public int Id { get; set; }
        [Column("EMAIL")]
        public string? Email { get; set; }
        [Column("BIRDTHDAY")]
        public string? Birdthday { get; set; }
        [Column("PHONE")]
        public string? Phone { get; set; }
        [Column("USERNAME")]
        public string Username { get; set; }
        //[DataType(DataType.Password)]
        [Column("PASSWORD")]
        public byte[] Password { get; set; }
        [Column("CONTRASENA")]
        public string Contrasena { get; set; }
        [Column("SALT")]
        public string Salt { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
