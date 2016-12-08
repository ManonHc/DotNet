using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCarpartage.Models;

namespace Modeles
{
    public class User
    {
        
        public User()
        {
            FavoriteUsers = new List<User>();

            IsFavoriteUserOf = new List<User>();

            PostsOwened = new List<Post>();   
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Mail { get; set; }

        
        public virtual Address Address { get; set; }

        // lien récursif de User 
        public virtual ICollection<User> FavoriteUsers { get; set; }

        public virtual ICollection<User> IsFavoriteUserOf { get; set; }


        // premier lien 1 à N de User à post. a priori ok dans Sql Server
        public virtual ICollection<Post> PostsOwened { get; set; }

        //lien vers ma table gérant ma N à N
        public virtual ICollection<UserPost> UserPosts { get; set; }

    }
}
