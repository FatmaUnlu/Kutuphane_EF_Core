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
    [Table("Yazarlar")]
    public partial class Yazar :BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string YazarAd { get; set; }

        [Required, StringLength(50)]
        public string YazarSoyad { get; set; }

        public virtual ICollection<KitapYazar> KitapYazarlar { get; set; } = new HashSet<KitapYazar>();
    }
}
