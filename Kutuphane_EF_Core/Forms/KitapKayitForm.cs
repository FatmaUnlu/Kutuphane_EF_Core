using Kutuphane_EF_Core.Data;
using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Repository;
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

            cmbKategori.DataSource = _kategoriRepo.KategoriListele();
            cmbKategori.DisplayMember = "Ad";

            cmbYayinEvi.DataSource = _yayineviRepo.YayinEviListele(); //yayınevi kayıt formu aç.
            cmbYayinEvi.DisplayMember = "YayineviAdi";

            cmbYazar.DataSource = _yazarRepo.YazarListele();
            cmbYazar.DisplayMember = "YazarAd-YazarSoyad";


        }

        private Kategori seciliKategori;
        private Yazar seciliYazar;
        //private void btnEkle_Click(object sender, EventArgs e)
        //{
        //    using (var tran = _dbContext.Database.BeginTransaction()) //using ifadeler garbage collector tarafından işlem bitince temizlenir
        //    {
        //        DialogResult result = MessageBox.Show("Ürün eklemek istiyor musunuz?", "Ürün Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.Yes)
        //        {
        //            //var yazar = cmbYazar.SelectedItem as Yazar;
        //            //var kategori = cmbKategori.SelectedItem as Kategori;
        //            var yayinEvi = cmbYayinEvi.SelectedItem as Yayinevi;

        //            try
        //            {
        //                var kitap = new Kitap()
        //                {
        //                    YayineviId = (int)yayinEvi?.Id, //null da gelebilir demek, null değilse de CustomerId değerini değişkene ata. 
        //                    Isbn = txtISBN.Text,
        //                    KitapAdi = txtKitapAd.Text,
        //                    SayfaSayisi = txtSayfaSayisi.Text,
        //                    YayinTarihi = dtpYayinTarihi.Value,

        //                };
        //                _kitapRepo.Add(kitap);

        //                //coklu seçimdeki her bir elemanın id sini kategori id ata
        //                //son grilen kitabın ıd sini bul.
        //                _dbContext.KitapKategoriler.Add(new KitapKategori()
        //                {
        //                    //Kitapıd ye son buldugun ıd yi ata
        //                    KitapId = kitap.Id,
        //                    //kategpriıd ye 
        //                    KategoriId = Kategori.Id,

        //                });


        //            }
        //            catch (Exception ex)
        //            {

        //                MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            };
        //            _urunRepo.Add(urun);
        //            UrunListele();
        //            MessageBox.Show("Ürün Ekleme işlemi Tamamlandı");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Ürün Ekleme işlemi Yapılmadı");

        //        }
        //    }
       // }
    }
}
