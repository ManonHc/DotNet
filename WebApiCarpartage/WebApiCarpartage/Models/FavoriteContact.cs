using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class FavoriteContact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public User FavoriteUser { get; set; }
        [Required]
        public User IsFavoUser { get; set; }



    }
}
