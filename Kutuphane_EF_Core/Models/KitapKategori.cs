using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Models
{
    [Table("KitapKategoriler")]
    public class KitapKategori
    { 
        public int KitapId { get; set; }
       
        [ForeignKey(nameof(KitapId))]
        public Kitap Kitap { get; set; }

        public int KategoriId { get; set; }
       
        [ForeignKey(nameof(KategoriId))]

        public  Kategori Kategori { get; set; }
      
    }
}
