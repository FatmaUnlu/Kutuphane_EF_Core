
using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Models.Abstracts;
using Kutuphane_EF_Core.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Repository
{
    public class EmanetRepo:RepositoryBase<Emanet, int>
    {
        public virtual List<Emanet> EmanetListele()
        {
            var query1 = _context.Emanetler
                .Where(x => x.IsDeleted == false).ToList();
            return query1;
            
        }
        public virtual List<Kitap> KitapListele2()
        {
            var query2 = _context.Kitaplar.Where(x => x.IsDeleted == false).ToList();
            return query2;
        }
        public virtual List<Uye> UyeLİstele2()
        {
            var query2 = _context.Uyeler.Where(x => x.IsDeleted == false).ToList();
            return query2;
        }
    }
}
