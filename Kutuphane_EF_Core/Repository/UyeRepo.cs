using Kutuphane_EF_Core.Models.Abstracts;
using Kutuphane_EF_Core.Repository.Abstracts;
using Kutuphane_EF_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Repository
{
    public  class UyeRepo : RepositoryBase<Uye, int>
    {
        public virtual List<UyeViewModel> UyeListele()
        {
            var query1 = _context.Uyeler
                .Where(x => x.IsDeleted == false)
                .Select(x => new UyeViewModel()
                {
                  Isim =x.UyeAd,
                  Soyisim=x.UyeSoyad,
                  TCKN=x.TCNo,
                  Eposta=x.Eposta,
                  Telefon =x.Telefon,
                  KayıtTarihi=(DateTime)x.CreatedDate,
                  Adres =x.Adres                 
            
                });
            return query1.ToList();
        }
    }
}

