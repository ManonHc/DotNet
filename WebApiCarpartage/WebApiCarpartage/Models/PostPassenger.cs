using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class PostPassenger : Post 
    {
        [Required]
        [Range(1, 6)]
        private int nbPersons;

        public int NbPersons
        {
            get
            {
                return nbPersons;
            }

            set
            {
                if (value >=1 && value <= 6)
                {
                    nbPersons = value;
                } 
            }
        }

        
       
    }
}
