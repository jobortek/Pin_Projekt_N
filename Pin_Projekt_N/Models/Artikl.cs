using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pin_Projekt_N.Models
{
    public class Artikl
    {
        [DisplayName("Šifra")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Naziv")]
        public string naziv { get; set; }

        [DisplayName("Cijena")]
        [Required]
        public Nullable<int> cijena { get; set; }

        [DisplayName("Količina")]
        [Required]
        public Nullable<int> kolicina { get; set; }

        [DisplayName("Opis")]
        public string opis { get; set; }

    }
}
