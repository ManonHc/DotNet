using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class PostDriver : Post
    {

        [Required]
        [Range(0, 50)]
        private int detourKm;
        [Required]
        [Range(1, 6)]
        private int amountPlace;

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
