using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(64)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(64)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(256)")]
        public string Password { get; set; }
    }
}
