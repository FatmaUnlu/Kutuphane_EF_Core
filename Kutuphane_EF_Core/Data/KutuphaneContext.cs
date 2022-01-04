using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_EF_Core.Data
{
    public class KutuphaneContext : DbContext
    {
        public KutuphaneContext() : base()
        {

        }

        //FluentApı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Kutuphane_EF_Core; Integrated Security = True;"); //connection string
            }
        }


        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Emanet> Emanetler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }

        public DbSet<KitapKategori> KitapKategoriler { get; set; }
        public DbSet<KitapYazar> KitapYazarlar { get; set; }





        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries() //neyin nasıl değiştriğini tutar
                  .Where(x => x.Entity is BaseEntity && x.State == EntityState.Added);

            foreach (var item in entries)
            {
                ((BaseEntity)item.Entity).CreatedDate = DateTime.Now;
            }


            entries = ChangeTracker.Entries()
                  .Where(x => x.Entity is BaseEntity && x.State == EntityState.Modified);

            foreach (var item in entries)
            {
                ((BaseEntity)item.Entity).UpdatedDate = DateTime.Now;
            }


            entries = ChangeTracker.Entries()
                  .Where(x => x.Entity is BaseEntity && x.State == EntityState.Deleted);

            foreach (var item in entries)
            {
                ((BaseEntity)item.Entity).DeletedDate = DateTime.Now;
                ((BaseEntity)item.Entity).IsDeleted = true;
                item.State = EntityState.Modified;
            }
            return base.SaveChanges();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<KitapKategori>()
                .ToTable("SiparisDetaylari");

            modelBuilder.Entity<KitapKategori>()
           .HasKey(x => new { x.KitapId, x.KategoriId });

            modelBuilder.Entity<KitapYazar>()
          .HasKey(x => new { x.KitapId, x.YazarId });



        }
    }
}
