using Kutuphane_EF_Core.Data;
using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Repository;
using Kutuphane_EF_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_EF_Core.Forms
{
    public partial class KitapKayitForm : Form
    {
        private KutuphaneContext _dbContext = new KutuphaneContext();
        private KitapRepo _kitapRepo = new KitapRepo();
        private KategoriRepo _kategoriRepo = new KategoriRepo();
        private YayinEviRepo _yayineviRepo = new YayinEviRepo();
        private YazarRepo _yazarRepo = new YazarRepo();


        public KitapKayitForm()
        {
            InitializeComponent();
            dgvKitapListesi.DataSource = _kitapRepo.KitapListele();


            cmbYayinEvi.DataSource = _yayineviRepo.YayinEviListele(); //yayınevi kayıt formu aç.
            cmbYayinEvi.DisplayMember = "YayineviAdi";

        }

        private Kategori seciliKategori;
        private Yazar seciliYazar;

        private void KitapDoldur()
        {
            dgvKitapListesi.DataSource = null;
            dgvKitapListesi.DataSource = _kitapRepo.KitapListele();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {           
            using (var tran = _dbContext.Database.BeginTransaction()) //using ifadeler garbage collector tarafından işlem bitince temizlenir
            {
                DialogResult result = MessageBox.Show("Kitap eklemek istiyor musunuz?", "Ürün Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {                   
                    var yayinEvi = cmbYayinEvi.SelectedItem as Yayinevi;
                    
                    try
                    {
                        var kitap = new Kitap()
                        {
                            YayineviId = (int)yayinEvi?.Id, //null da gelebilir demek, null değilse de CustomerId değerini değişkene ata. 
                            Isbn = maskedtxtISBN.Text,
                            KitapAdi = txtKitapAd.Text,
                            SayfaSayisi = txtSayfaSayisi.Text,
                            YayinTarihi = dtpYayinTarihi.Value,                            
                        };
                        _kitapRepo.Add(kitap);
                        KitapDoldur();
                      
                        var kitaplar=_kitapRepo.GetAll().Where(x=> x.Isbn == maskedtxtISBN.Text && x.IsDeleted==false).FirstOrDefault() as Kitap;

                        if (kitaplar == null) return;
                        foreach (Kategori item in checkedLbKategori.CheckedItems)
                        {
                            var kitapKategori = new KitapKategori()
                            {
                                KitapId = kitaplar.Id,
                                KategoriId = item.Id
                            };
                            _dbContext.KitapKategoriler.Add(kitapKategori);
                            _dbContext.SaveChanges();

                            //_dbContext.KitapKategoriler.Add(new KitapKategori()
                            //{
                            //    //Kitapıd ye son buldugun ıd yi ata
                            //    KitapId = kitaplar.Id,
                            //    //kategpriıd ye buldugun ıd yi ata
                            //    KategoriId = item.Id
                            //});
                        }                        
                        
                        foreach (Yazar item in checkedLbYazar.CheckedItems)
                        {
                            var kitapYazar = new KitapYazar()
                            {
                                KitapId = kitaplar.Id,
                                YazarId = item.Id
                            };
                            _dbContext.KitapYazarlar.Add(kitapYazar);
                            _dbContext.SaveChanges();
                            //_dbContext.KitapYazarlar.Add(new KitapYazar()
                            //{

                            //    KitapId = kitaplar.Id,

                            //    YazarId = item.Id
                            //});                           
                        }

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };

                    KitapDoldur();
                    MessageBox.Show("Kitap Ekleme işlemi Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Kitap Ekleme işlemi Yapılmadı");
                }
            }
        }

        private void KitapKayitForm_Load(object sender, EventArgs e)
        {
            var kategori =_kategoriRepo.GetAll().Where(x => x.IsDeleted == false).ToList();
            checkedLbKategori.DataSource=kategori;
            checkedLbKategori.DisplayMember = "KategoriAdi";
            checkedLbKategori.ValueMember = "Id";

            var yazar = _yazarRepo.GetAll().Where(x => x.IsDeleted == false).ToList();
            checkedLbYazar.DataSource = yazar;
            //checkedLbYazar.DisplayMember = "YazarAd";
            //checkedLbYazar.ValueMember = "Id";
        }
    }
}
