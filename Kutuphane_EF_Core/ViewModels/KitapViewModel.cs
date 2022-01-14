using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.ViewModels
{
    public class KitapViewModel
    {
        public string KitapAd { get; set; }
        public string Kategori { get; set; }
        public string Yazar { get; set; }
        public string YayınEvi { get; set; }
        public string SayfaSayisi { get; set; }
        public string Isbn { get; set; }
        public DateTime YayinTarihi { get; set; }

        //public int Adet { get; set; } = 0;
    }
}
