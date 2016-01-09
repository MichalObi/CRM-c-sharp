using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crm.Models
{
    public class myModel
    {
        [ScaffoldColumn(false)]
        public int myModelID { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Imie")]
        public string FirstMidName { get; set; }

        [Required]
        [Display(Name = "Firma")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Rok")]
        public int OpeningYear { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public string Adress { get; set; }

        [Required]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Display(Name = "Notatka")]
        public string Note { get; set; }
    }
}