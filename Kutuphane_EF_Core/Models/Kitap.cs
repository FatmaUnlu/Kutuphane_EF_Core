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
    [Table("Kitaplar")]
    public class Kitap :BaseEntity, IKey<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(13)]
        public string Isbn { get; set; }

        [Required, StringLength(50)]
        public string KitapAdi { get; set; }
        [Required]
        public DateTime YayinTarihi { get; set; }
        [Required]
        public string SayfaSayisi { get; set; }
        
        public int YayineviId { get; set; }
        [ForeignKey(nameof(YayineviId))]
        public Yayinevi Yayinevi { get; set; }
        
        public  ICollection <Emanet> Emanetler { get; set; } = new HashSet<Emanet>();
        public  ICollection<KitapKategori> KitapKategoriler { get; set; } = new HashSet<KitapKategori>();
        public  ICollection<KitapYazar> KitapYazarlar { get; set; } = new HashSet<KitapYazar>();
    }
}
