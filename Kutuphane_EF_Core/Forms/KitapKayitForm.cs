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
                DialogResult result = MessageBox.Show("Kitap eklemek istiyor musunuz?", "Kitap Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var tran = _dbContext.Database.BeginTransaction()) //using ifadeler garbage collector tarafından işlem bitince temizlenir
            {
                DialogResult result = MessageBox.Show("Seçili kitabı güncellemek istiyor musunuz?", "Kitap Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var yayinEvi = cmbYayinEvi.SelectedItem as Yayinevi;
                    var secilikitap = (KitapViewModel)this.dgvKitapListesi.CurrentRow.DataBoundItem;

                    var kitap = _kitapRepo.GetAll().FirstOrDefault(x => x.Isbn == secilikitap.Isbn && x.IsDeleted == false) as Kitap;
                    try
                    {
                        if (kitap == null) return;

                        kitap.KitapAdi = txtKitapAd.Text;
                        kitap.YayineviId = (int)yayinEvi?.Id;
                        kitap.SayfaSayisi = txtSayfaSayisi.Text;
                        kitap.YayinTarihi=dtpYayinTarihi.Value;
                        kitap.Isbn=maskedtxtISBN.Text;
                        _kitapRepo.Update(kitap);

                        Console.WriteLine();

                        //var kitapKategori = _kitapKategoriRepo.GetById(kitap.Id) as KitapKategori;
                        List<KitapKategori> kitapKategori = _dbContext.KitapKategoriler.Where(x => x.KitapId == kitap.Id).ToList();
                        var kitapKategori1 = _dbContext.KitapKategoriler.Where(x => x.KitapId == kitap.Id);
                   
                       
                        foreach (Kategori item in checkedLbKategori.CheckedItems)
                        {
                            foreach (var kitKat in kitapKategori)
                            {
                                kitKat.KitapId= kitap.Id;
                                kitKat.KategoriId = item.Id;
                                _dbContext.KitapKategoriler.Update(kitKat);
                            }
                            
                            //kitapKategori[0].KitapId = kitap.Id;
                            //kitapKategori.KategoriId = item.Id;
                          
                            //_dbContext.KitapKategoriler.Update(kitapKategori);
                            //_dbContext.SaveChanges();                       
                        }

                        List<KitapYazar> kitapYazar = _dbContext.KitapYazarlar.Where(x => x.KitapId == kitap.Id).ToList();
                        var kitapYazar1 = _dbContext.KitapYazarlar.Where(x => x.KitapId == kitap.Id);


                        foreach (Yazar item in checkedLbYazar.CheckedItems)
                        {
                            foreach (var kityaz in kitapYazar)
                            {
                                kityaz.KitapId = kitap.Id;
                                kityaz.YazarId = item.Id;
                                _dbContext.KitapYazarlar.Update(kityaz);
                            }

                            //kitapKategori[0].KitapId = kitap.Id;
                            //kitapKategori.KategoriId = item.Id;

                            //_dbContext.KitapKategoriler.Update(kitapKategori);
                            //_dbContext.SaveChanges();                       
                        }

                        tran.Commit();
                        KitapDoldur();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };

                    KitapDoldur();
                    MessageBox.Show("Kitap Güncelleme işlemi Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Kitap Güncelleme işlemi Yapılmadı");
                }
            }
        }

        private void dgvKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilisatır = (KitapViewModel)dgvKitapListesi.CurrentRow.DataBoundItem;
            txtKitapAd.Text = secilisatır.KitapAd;
            cmbYayinEvi.SelectedItem = secilisatır.YayınEvi;
            txtSayfaSayisi.Text = secilisatır.SayfaSayisi;
            maskedtxtISBN.Text = secilisatır.Isbn;
            dtpYayinTarihi.Value = secilisatır.YayinTarihi;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KitapDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            var seciliKitap = this.dgvKitapListesi.CurrentRow.DataBoundItem as KitapViewModel;
            var uye = _kitapRepo.GetAll().FirstOrDefault(x => x.Isbn == seciliKitap.Isbn) as Kitap;
            if (seciliKitap == null) return;

            DialogResult cevap = MessageBox.Show("Seçili kitabı silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    _kitapRepo.Remove(uye);
                    MessageBox.Show("Kitap silme işlemi tamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    KitapDoldur();
                }
            }
            else
            {
                MessageBox.Show("Kitap silme işlemi yapılmadı");
            }
        }

    }
}
