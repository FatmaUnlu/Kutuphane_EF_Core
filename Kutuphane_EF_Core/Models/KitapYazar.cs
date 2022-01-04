using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Models
{
    [Table("KitapYazarlar")]
    public class KitapYazar
    {
        public int KitapId { get; set; }

        [ForeignKey(nameof(KitapId))]
        public Kitap Kitap { get; set; }

        public int YazarId { get; set; }

        [ForeignKey(nameof(YazarId))]

        public Yazar Yazar { get; set; }
    }
}
