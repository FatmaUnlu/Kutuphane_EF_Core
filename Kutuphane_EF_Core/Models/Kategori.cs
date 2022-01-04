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
    [Table("Kategoriler")]
    public class Kategori:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string KategoriAdi { get; set; }

        public  ICollection<KitapKategori> KitapKategoriler { get; set; } = new HashSet<KitapKategori>();
    }
}
