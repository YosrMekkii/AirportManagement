using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "L'adresse email est obligatoire.")]
        [EmailAddress(ErrorMessage = "L'adresse email doit être valide.")]
        public string EmailAddress { get; set; }

        /* [Required(ErrorMessage = "Le prénom est obligatoire.")]
         [StringLength(250, ErrorMessage = "Le prénom ne peut pas dépasser 250 caractères.")]
         [MaxLength(300)]  // Limitation côté base de données
         public string FirstName { get; set; }

         [Required(ErrorMessage = "Le nom de famille est obligatoire.")]
         [StringLength(250, ErrorMessage = "Le nom de famille ne peut pas dépasser 250 caractères.")]
         [MaxLength(300)]  // Limitation côté base de données
         public string LastName { get; set; } */

        [Required(ErrorMessage = "Le nom complet est obligatoire.")]
        public FullName FullName { get; set; } = new FullName();

        [Key]
        public string PassportNumber { get; set; }
        
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get; set; }
        public virtual string PassengerType { get { return "Unknown passenger type"; } }
        public override string ToString()
        {
            return $"PassportNumber : {PassportNumber}, FullName :{FullName}";
        }
    }
}
