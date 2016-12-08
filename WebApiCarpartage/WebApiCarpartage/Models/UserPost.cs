using Modeles;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCarpartage.Models
{
    public class UserPost
    {
        // les choses testé était de mettre String objet maj et int? mais ne fonctionne pas pour autant
        public string UserId { get; set; }
        public int PostId { get; set; }
        public bool Alert { get; set; }


       // [ForeignKey("UserId")]
       // public virtual ApplicationUser User { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
        
    }
}