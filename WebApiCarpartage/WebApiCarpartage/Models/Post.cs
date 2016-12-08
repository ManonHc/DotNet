using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCarpartage.Models;

namespace Modeles
{
    public class Post
    {
        
        // Les attributs de tous
        
        [Range(1, 3)]
        private int sizeShopping;

        // attributs de postPassenger
        [Range(0, 6)]
        private int nbPersons;


        //attributs de PostDriver
        
        [Range(0, 50)]
        private int detourKm;
        
        [Range(0, 6)]
        private int amountPlace;

        // toutes les propriétés
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TimePeriod { get; set; }
        
        // ici n'est il pas censé créer un truc en plus dans le DB?
        public virtual ICollection<string> FavoriteMarket { get; set; }

        [Required]
        public virtual ApplicationUser UserOwner { get; set; }

        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string typeOfPost { get; set; }



        public virtual ICollection<UserPost> UserPosts { get; set; }



        public int SizeShopping
        {
            get
            {
                return sizeShopping;
            }

            set
            {
                if(value >= 1 && value <= 3)
                {
                    sizeShopping = value;
                }
            }
        }

       

        public int NbPersons
        {
            get
            {
                return nbPersons;
            }

            set
            {
                if (value >= 1 && value <= 6)
                {
                    nbPersons = value;
                }
            }
        }


        public int DetourKm
        {
            get
            {
                return detourKm;
            }

            set
            {
                if (value >= 0 && value <= 50)
                {
                    detourKm = value;
                }
            }
        }

        public int AmountPlace
        {
            get
            {
                return amountPlace;
            }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    amountPlace = value;
                }
            }
        }

    }
}

