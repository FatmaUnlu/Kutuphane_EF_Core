using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Models.Abstracts
{
    [Table(name: "Uyeler")]
    public class Uye:BaseEntity ,IKey<int>
    {
        [Key]
        public int Id { get; set; }
       
        [Required, StringLength(50)]
        public string UyeAd { get; set; }
 
        [Required, StringLength(50)]
        public string UyeSoyad { get; set; }
        
        [Required]
        public char Cinsiyet { get; set; }
  
        [Required, StringLength(11)]
        public string Telefon { get; set; }

        [Required, StringLength(35)]
        public string Eposta { get; set; }

        public int AdresId { get; set; }
 
        [ForeignKey(nameof(AdresId))]
        public Adres Adres { get; set; }

        public virtual ICollection<Emanet> Emanetlers { get; set; } = new HashSet<Emanet>();
    }
}
