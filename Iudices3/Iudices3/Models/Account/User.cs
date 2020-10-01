using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iudices3.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string NewPassword { get; set; }

        public string Salt { get; set; }

        public int zipCode { get; set; }

        public string Role { get; set; }

        public bool IsAdmin { get; set; }
    }
}
