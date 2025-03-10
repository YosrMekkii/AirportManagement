using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        [DataType(DataType.MultilineText, ErrorMessage = "Les informations de santé doivent être saisies sur plusieurs lignes.")]
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override string PassengerType { get { return "Traveller passenger type"; } }
        public override string ToString()
        {
            return base.ToString() + $" -- Nationality : {Nationality}";
        }
    }
}
