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
    [Table("Yayinevleri")]
    public class Yayinevi :BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string YayineviAdi { get; set; }

        public  ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();
    }
}
