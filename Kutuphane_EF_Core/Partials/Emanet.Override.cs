﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kutuphane_EF_Core.Models
{
    public partial class Emanet
    {
        public override string ToString()
        {
            return $"{KitapId} - {UyeId} - {EmanetTarihi} - {Teslimtarihi} - {TeslimDurumu}";
        }
    }
}
