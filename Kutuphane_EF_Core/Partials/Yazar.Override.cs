using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Models
{
    public partial class Yazar
    {
        public override string ToString()
        {
            return $"*{YazarAd} {YazarSoyad}";
        }
    }
}
