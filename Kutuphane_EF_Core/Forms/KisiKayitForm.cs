using Kutuphane_EF_Core.Models.Abstracts;
using Kutuphane_EF_Core.Repository;
using Kutuphane_EF_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_EF_Core.Forms
{
    public partial class KisiKayitForm : Form
    {
        private UyeRepo _uyeRepo = new UyeRepo();
        public KisiKayitForm()
        {
            InitializeComponent();
            dgvKisiler.DataSource = _uyeRepo.UyeListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kişiyi eklemek istiyor musunuz?", "Yazar Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                var uye = new Uye();
                try
                {
                    uye.UyeAd = txtİsim.Text;
                    uye.UyeSoyad = txtSoyisim.Text;
                    uye.TCNo = maskedtxtTCKN.Text;

                    Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    
                    if (emailRegex.IsMatch(txtEposta.Text))
                    {
                        errorProvider1.Clear();
                        uye.Eposta = txtEposta.Text;
                    }
                    else
                    {
                        errorProvider1.SetError(this.txtEposta, "Lütfen uygun mail adresi gririniz");
                        return;
                    }
                    //uye.Eposta=txtEposta.Text;
                    uye.Adres = txtAdres.Text;
                    uye.Telefon=maskedtxtTelefon.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                _uyeRepo.Add(uye);
                UyeDoldur();
             
                MessageBox.Show("Yazar ekleme işlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Yazar ekleme işlemi Yapılmadı");

            }
            
        }

        public void  UyeDoldur()
        {
            dgvKisiler.DataSource = null;
            dgvKisiler.DataSource = _uyeRepo.UyeListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            var seciliUye = this.dgvKisiler.CurrentRow.DataBoundItem as UyeViewModel;
            var uye = _uyeRepo.GetAll().FirstOrDefault(x => x.TCNo == seciliUye.TCKN) as Uye;
            if (seciliUye == null) return;

            DialogResult cevap = MessageBox.Show("Seçili üyeyi silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    _uyeRepo.Remove(uye);
                    MessageBox.Show("Üye silme işlemi tamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    UyeDoldur();
                }
            }
            else
            {
                MessageBox.Show("Üye silme işlemi yapılmadı");
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            var seciliUye = (UyeViewModel)this.dgvKisiler.CurrentRow.DataBoundItem;
            if (seciliUye == null) return;

            var uye = _uyeRepo.GetAll().FirstOrDefault(x => x.TCNo == seciliUye.TCKN) as Uye;
            uye.UyeAd = txtİsim.Text;
            uye.UyeSoyad = txtSoyisim.Text;
            uye.TCNo = seciliUye.TCKN;
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (emailRegex.IsMatch(txtEposta.Text))
            {
                errorProvider1.Clear();
                uye.Eposta = txtEposta.Text;
            }
            else
            {
                errorProvider1.SetError(this.txtEposta, "Lütfen uygun mail adresi gririniz");
                return;
            }

            uye.Adres = txtAdres.Text;
            uye.Telefon = maskedtxtTelefon.Text;

            DialogResult result = MessageBox.Show("Seçili üyeyi güncellemek istiyor musunuz?", "Kategori Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _uyeRepo.Update(uye);
                UyeDoldur();

                MessageBox.Show("Üye Güncelleme İşlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Üye Güncelleme İşlemi Yapılmadı");
            }
        }

        private void dgvKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilisatır = (UyeViewModel)dgvKisiler.CurrentRow.DataBoundItem;
            txtİsim.Text = secilisatır.Isim;
            txtSoyisim.Text = secilisatır.Soyisim;
            maskedtxtTCKN.Text = secilisatır.TCKN;
            maskedtxtTelefon.Text = secilisatır.Telefon;
            txtEposta.Text = secilisatır.Eposta;
            txtAdres.Text = secilisatır.Adres;          
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            UyeDoldur();
        }
    }
}
