using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iudices3.Models
{
    public class Juror
    {
        public int ID;

        [Required]
        public string firstName;

        [Required]
        public string lastName;

        [Required]
        public string streetAddress;

        [Required]
        public string city;

        [Required]
        public string state;

        [Required]
        public int zipcode;
    }
}
