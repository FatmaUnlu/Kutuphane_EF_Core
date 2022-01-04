using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Repository
{
    public class YazarRepo : RepositoryBase<Yazar, int>
    {
        public virtual List<Yazar> YazarListele()
        {
            var query1 = _context.Yazarlar
                .Where(x => x.IsDeleted == false).ToList();          
            return query1;         
        }
    }
}
