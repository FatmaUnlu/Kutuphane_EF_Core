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
    [Table("Emanetler")]
    public class Emanet:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }
        
        public int UyeId { get; set; }
        [ForeignKey(nameof(UyeId))]
        public Uye Uye { get; set; }

        public int KitapId { get; set; }
        [ForeignKey(nameof(KitapId))]
        public Kitap Kitap { get; set; }
        [Required]
        public DateTime EmanetTarihi { get; set; }
        [Required]
        public DateTime Teslimtarihi { get; set; }
        [Required]
        public string TeslimDurumu { get; set; }


    }
}
