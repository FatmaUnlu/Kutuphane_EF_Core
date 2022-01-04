using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Repository.Abstracts;
using Kutuphane_EF_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Repository
{
    public class KategoriRepo : RepositoryBase<Kategori, int>
    {
        public virtual List<KategoriViewModel> KategoriListele()
        {
            var query1 = _context.Kategoriler
                .Where(x => x.IsDeleted == false)
                .Select(x => new KategoriViewModel()
                {
                    Id = x.Id,
                    Ad = x.KategoriAdi
                });
            return query1.ToList();
        }
    }
}
