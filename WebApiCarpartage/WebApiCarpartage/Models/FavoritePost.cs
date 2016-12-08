using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class FavoritePost
    {
        [Key]
        public Boolean Alert { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Post Post { get; set; }

    }
}
