using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Modeles;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApiCarpartage.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser, consultez http://go.microsoft.com/fwlink/?LinkID=317594 pour en savoir davantage.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Notez que authenticationType doit correspondre à l'instance définie dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Ajouter des revendications d’utilisateur personnalisées ici
            return userIdentity;
        }

        [Required]
        public string Phone { get; set; }
        
        public virtual Address Address { get; set; }

        // lien récursif de User 
        public virtual ICollection<ApplicationUser> FavoriteUsers { get; set; }

        public virtual ICollection<ApplicationUser> IsFavoriteUserOf { get; set; }


        // premier lien 1 à N de User à post. a priori ok dans Sql Server
        public virtual ICollection<Post> PostsOwened { get; set; }

        //lien vers ma table gérant ma N à N
        public virtual ICollection<UserPost> UserPosts { get; set; }
    }






    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<Modeles.Post> Posts { get; set; }

        //public System.Data.Entity.DbSet<ApplicationUser> Users { get; set; }

        public System.Data.Entity.DbSet<Modeles.Address> Addresses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPost>()
                .HasKey(c => new { c.UserId, c.PostId });
            modelBuilder.Entity<Post>()
                .HasMany(c => c.UserPosts)
                .WithOptional()
                .HasForeignKey(c => c.PostId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(c => c.UserPosts)
                .WithOptional()
                .HasForeignKey(c => c.UserId)
                .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            // Appel de la fonction de base sinon les liens ne sont pas créé pour ApplicationUser
            base.OnModelCreating(modelBuilder);

        }
    }
}