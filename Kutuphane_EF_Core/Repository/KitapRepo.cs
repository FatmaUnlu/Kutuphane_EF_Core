using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Repository.Abstracts;
using Kutuphane_EF_Core.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Repository
{
    public class KitapRepo : RepositoryBase<Kitap, int>
    {
        public virtual List<KitapViewModel> KitapListele()
        {
           
            var query = _context.Kitaplar
                .Include(x => x.Yayinevi)
                .Include(x => x.KitapKategoriler)
                .ThenInclude(x => x.Kategori)

                .Include(x => x.KitapYazarlar)
                .ThenInclude(x => x.Yazar)

                .Select(x => new KitapViewModel()
                {
                    KitapAd = x.KitapAdi,
                    YayınEvi = x.Yayinevi.YayineviAdi,
                    Yazar = string.Join(',', x.KitapYazarlar.Select(z => z.Yazar.YazarAd + "" + z.Yazar.YazarSoyad).ToList()),
                    Kategori = string.Join(',', x.KitapKategoriler.Select(y => y.Kategori.KategoriAdi).ToList()),

                });

            return query.ToList();

            //var querylist = from kitap in _dbContext.Kitaplars
            //                join yayinevi in _dbContext.Yayinevleris on kitap.YayineviId equals yayinevi.YayineviId
            //                join kitapKategori in _dbContext.KitapKategoris on kitap.KitapId equals kitapKategori.KitapId
            //                join kategori in _dbContext.Kategorilers on kitapKategori.KategoriId equals kategori.KategoriId
            //                join kitapYazar in _dbContext.Kitapyazars on kitap.KitapId equals kitapYazar.KitapId
            //                join yazar in _dbContext.Yazarlars on kitapYazar.YazarId equals yazar.YazarId
            //                group new { kitap, yayinevi, kategori, yazar } by new { kitap.KitapAdi, yayinevi.YayineviAdi, kategori.KategoriAdi, yazar.YazarAd, yazar.YazarSoyad } into mygroup
            //                select new DgvViewModel
            //                {
            //                    KitapAd = mygroup.Key.KitapAdi,
            //                    YayınEvi = mygroup.Key.YayineviAdi,
            //                    Kategori = mygroup.Key.KategoriAdi,
            //                    YazarAdı = mygroup.Key.YazarAd,
            //                    YazarSoyadı = mygroup.Key.YazarSoyad,
            //                    Adet = mygroup.Count()
            //                };
            //dgvKitapListesi.DataSource = querylist
            //    .OrderBy(x => x.KitapAd)
            //    .ToList();
        }
    }
}
