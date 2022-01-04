using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Repository
{
    public class YayinEviRepo : RepositoryBase<Yayinevi, int>
    {
        public virtual List<Yayinevi> YayinEviListele()
        {
            var query1 = _context.Yayinevleri
                .Where(x => x.IsDeleted == false)
                .Select(x => new Yayinevi
                {
                    Id = x.Id,
                    YayineviAdi = x.YayineviAdi
                }).ToList();

            return query1;
        }

    }
}
