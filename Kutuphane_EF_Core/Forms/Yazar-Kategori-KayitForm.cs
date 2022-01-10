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
    public partial class Yazar_Kategori_KayitForm : Form
    {
        private YazarRepo _yazarRepo = new YazarRepo();
        private KategoriRepo _kategoriRepo = new KategoriRepo();
        private YayinEviRepo _yayineviRepo = new YayinEviRepo();

        public Yazar_Kategori_KayitForm()
        {
            InitializeComponent();
            lstYazarlar.DataSource = _yazarRepo.YazarListele();
            kategoriDoldur();
            yayneviDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu yazarı eklemek istiyor musunuz?", "Yazar Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                var yazar = new Yazar();
                try
                {
                    yazar.YazarAd = txtYazarAd.Text;
                    yazar.YazarSoyad = txtYazarSoyad.Text;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                _yazarRepo.Add(yazar);
                lstYazarlar.DataSource = _yazarRepo.YazarListele();
                MessageBox.Show("Yazar ekleme işlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Yazar ekleme işlemi Yapılmadı");

            }
        }

        private Yazar seciliYazar;
        private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedItem == null) return;
            seciliYazar = lstYazarlar.SelectedItem as Yazar;

            txtYazarAd.Text = seciliYazar.YazarAd;
            txtYazarSoyad.Text = seciliYazar.YazarSoyad;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            seciliYazar = (Yazar)lstYazarlar.SelectedItem;
            if (seciliYazar == null) return;

            DialogResult cevap = MessageBox.Show("Seçili yazarı silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    _yazarRepo.Remove(seciliYazar);
                    MessageBox.Show("Yazar silme işlemi tamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    lstYazarlar.DataSource = _yazarRepo.YazarListele();
                }
            }
            else
            {
                MessageBox.Show("Yazar silme işlemi yapılmadı");

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliYazar = (Yazar)lstYazarlar.SelectedItem;
            if (seciliYazar == null) return;

            DialogResult cevap = MessageBox.Show("Seçili yazarı güncellemek ister misiniz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (cevap == DialogResult.Yes)
                {
                    var yazar = _yazarRepo.GetById(seciliYazar.Id);
                    yazar.YazarAd = txtYazarAd.Text;
                    yazar.YazarSoyad = txtYazarSoyad.Text;

                    _yazarRepo.Update(yazar);
                }
                else
                {
                    MessageBox.Show("Yazar güncelleme işlemi yapıldı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Yazar güncelleme işlemi yapılmadı");

            }
            finally
            {
                lstYazarlar.DataSource = _yazarRepo.YazarListele();
            }

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            lstYazarlar.DataSource = _yazarRepo.YazarListele();
        }
        //private KategoriViewModel seciliKategori;
        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (lstViewKategori.SelectedItems.Count == 0) return;

            var seciliKategori = this.lstViewKategori.SelectedItems[0].Tag as KategoriViewModel;
            var kategori = _kategoriRepo.GetAll().FirstOrDefault(x => x.Id == seciliKategori.Id) as Kategori;
            if (seciliKategori == null) return;

            DialogResult cevap = MessageBox.Show("Seçili kategoriyi silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    _kategoriRepo.Remove(kategori);
                    MessageBox.Show("kategori silme işlemi tamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    kategoriDoldur();
                }
            }
            else
            {
                MessageBox.Show("Kategori silme işlemi yapılmadı");

            }

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kategoriyi eklemek istiyor musunuz?", "Kategori Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var kategori = new Kategori();
                try
                {
                    kategori.KategoriAdi = txtKategoriAd.Text;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                _kategoriRepo.Add(kategori);
                kategoriDoldur();

                MessageBox.Show("Kategori ekleme işlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kategori ekleme işlemi Yapılmadı");

            }
        }

        private List<KategoriViewModel> _kategori = new List<KategoriViewModel>();
        private void kategoriDoldur()
        {
            lstViewKategori.Columns.Clear();
            lstViewKategori.Items.Clear();
            lstViewKategori.View = View.Details;
            lstViewKategori.MultiSelect = false;
            lstViewKategori.FullRowSelect = true;

            lstViewKategori.Columns.Add("******************************Kategori*******************************");
            _kategori = _kategoriRepo.KategoriListele();
            foreach (var item in _kategori)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.Tag = item;
                // viewItem.SubItems.Add(item.Ad);
                lstViewKategori.Items.Add(viewItem);
            }

            lstViewKategori.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {

            var seciliKategori = (KategoriViewModel)this.lstViewKategori.SelectedItems[0].Tag;
            if (seciliKategori == null) return;

            var kategori = _kategoriRepo.GetById(seciliKategori.Id) as Kategori;

            kategori.KategoriAdi = txtKategoriAd.Text;

            DialogResult result = MessageBox.Show("Seçili kategoriyi güncellemek istiyor musunuz?", "Kategori Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _kategoriRepo.Update(kategori);
                kategoriDoldur();

                MessageBox.Show("Kategori Güncelleme İşlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kategori Güncelleme İşlemi Yapılmadı");
            }
        }

        private void lstViewKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliKategori = (KategoriViewModel)this.lstViewKategori.SelectedItems[0].Tag;

            txtKategoriAd.Text = seciliKategori.Ad;

        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            kategoriDoldur();
        }

        private void btnYayineviEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu yayınevini eklemek istiyor musunuz?", "Kategori Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var yayinevi = new Yayinevi();
                try
                {
                    yayinevi.YayineviAdi = txtYayinevi.Text;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                _yayineviRepo.Add(yayinevi);
                yayneviDoldur();

                MessageBox.Show("Yayınevi ekleme işlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Yayınevi ekleme işlemi Yapılmadı");

            }
        }

        private List<Yayinevi> _yayinevi = new List<Yayinevi>();
        private void yayneviDoldur()
        {
            lstViewYayinevi.Columns.Clear();
            lstViewYayinevi.Items.Clear();
            lstViewYayinevi.View = View.Details;
            lstViewYayinevi.MultiSelect = false;
            lstViewYayinevi.FullRowSelect = true;

            lstViewYayinevi.Columns.Add("******************************Yayınevi*******************************");
            _yayinevi = _yayineviRepo.YayinEviListele();
            foreach (var item in _yayinevi)
            {
                ListViewItem viewItem = new ListViewItem(item.YayineviAdi);
                viewItem.Tag = item;
                // viewItem.SubItems.Add(item.Ad);
                lstViewYayinevi.Items.Add(viewItem);
            }

            lstViewYayinevi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnYayineviSil_Click(object sender, EventArgs e)
        {
            if (lstViewYayinevi.SelectedItems.Count == 0) return;

            var seciliYayinevi = this.lstViewYayinevi.SelectedItems[0].Tag as Yayinevi;
            var yayinevi = _yayineviRepo.GetAll().FirstOrDefault(x => x.Id == seciliYayinevi.Id && x.IsDeleted == false) as Yayinevi;
            if (seciliYayinevi == null) return;

            DialogResult cevap = MessageBox.Show("Seçili yayınevini silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    _yayineviRepo.Remove(yayinevi);
                    MessageBox.Show("Yayınevi silme işlemi tamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    yayneviDoldur();
                }
            }
            else
            {
                MessageBox.Show("Yayınevi silme işlemi yapılmadı");

            }
        }

        private void btnYayineviGüncelle_Click(object sender, EventArgs e)
        {
            var seciliYayinevi = (Yayinevi)this.lstViewYayinevi.SelectedItems[0].Tag;
            if (seciliYayinevi == null) return;

            var yayinevi = _yayineviRepo.GetById(seciliYayinevi.Id) as Yayinevi;

            yayinevi.YayineviAdi = txtYayinevi.Text;

            DialogResult result = MessageBox.Show("Seçili yayınevini güncellemek istiyor musunuz?", "Kategori Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _yayineviRepo.Update(yayinevi);
                yayneviDoldur();

                MessageBox.Show("Yayınevi Güncelleme İşlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Yayınevi Güncelleme İşlemi Yapılmadı");
            }
        }

        private void lstViewYayinevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliYayinevi = (Yayinevi)this.lstViewYayinevi.SelectedItems[0].Tag;

            txtYayinevi.Text = seciliYayinevi.YayineviAdi;
        }
    }
}


