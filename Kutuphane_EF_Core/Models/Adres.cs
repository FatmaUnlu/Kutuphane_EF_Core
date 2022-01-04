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
    [Table(name: "Adresler")]
    public class Adres : BaseEntity, IKey<int>
    {
        [Key]
        public int Id { get ; set ; }
        [Required, StringLength(50)]
        public string Il { get; set; }
        [Required, StringLength(50)]
        public string Ilce { get; set; }
        [Required, StringLength(50)]
        public string Cadde { get; set; }
        [Required, StringLength(50)]
        public string Sokak { get; set; }
        [Required, StringLength(50)]
        public string Mahalle { get; set; }
        [Required]
        public int BinaNo { get; set; }
        [Required]
        public int Kat { get; set; }
        public int PostaKodu { get; set; }

        public  ICollection<Uye> Uyeler { get; set; } = new HashSet<Uye>();
    }
}
