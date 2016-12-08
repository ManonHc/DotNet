using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCarpartage.Models;

namespace Modeles
{
    public class Address
    {
        [Required]
        [Range(1, 99)]
        private int number;

        [Key]
        public int Id { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Range(0, 99999)]
        public int ZipCode { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }
        //public string UserId { get; set; }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if(value >= 1 && value <= 99)
                {
                    number = value;
                }
            }
        }
    }
}
