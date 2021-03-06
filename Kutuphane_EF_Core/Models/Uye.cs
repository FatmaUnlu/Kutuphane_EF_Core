using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Models
{
    [Table(name: "Uyeler")]
    public partial class Uye:BaseEntity ,IKey<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(11)]
        public string TCNo { get; set; }

        [Required, StringLength(50)]
        public string UyeAd { get; set; }
 
        [Required, StringLength(50)]
        public string UyeSoyad { get; set; }
          
        [Required, StringLength(14)]
        public string Telefon { get; set; }

        [Required, StringLength(35)]
        public string Eposta { get; set; }

        [Required, StringLength(250)]
        public string Adres { get; set; }

        public virtual ICollection<Emanet> Emanetlers { get; set; } = new HashSet<Emanet>();
    }
}
