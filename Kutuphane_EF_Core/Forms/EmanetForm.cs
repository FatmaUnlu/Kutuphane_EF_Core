
using Kutuphane_EF_Core.Models;
using Kutuphane_EF_Core.Models.Abstracts;
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
    public partial class EmanetForm : Form
    {
        private EmanetRepo _emanetRepo = new EmanetRepo();
        private KitapRepo _kitapRepo = new KitapRepo();
        private UyeRepo _uyeRepo = new UyeRepo();

        public EmanetForm()
        {
            InitializeComponent();
        }

        private void EmanetForm_Load(object sender, EventArgs e)
        {
            lstEmanetler.DataSource = _emanetRepo.EmanetListele();

            cmbKitapAd.DataSource = _emanetRepo.KitapListele2();
            cmbKitapAd.DisplayMember = "KitapAdi";
            cmbKitapAd.ValueMember = "Id";

            cmbUyeAdi.DataSource = _emanetRepo.UyeLİstele2();

        }

        private void EmanetListele()
        {
            lstEmanetler.DataSource = _emanetRepo.EmanetListele();
        }
        private Kitap seciliKitapAd;
        private Uye seciliUye;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kitabı emanet olarak eklemek istiyor musunuz?", "Emanet Bilgisi Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var kitap = cmbKitapAd.SelectedItem as Kitap;
                var uye = cmbUyeAdi.SelectedItem as Uye;

                if (cmbKitapAd.SelectedItem != null)
                {
                    seciliKitapAd = (Kitap)cmbKitapAd.SelectedItem;
                }
                else
                {
                    seciliKitapAd = null;
                }
                if (cmbUyeAdi.SelectedItem != null)
                {
                    seciliUye = (Uye)cmbUyeAdi.SelectedItem;
                }
                else
                {
                    seciliUye = null;
                }

                try
                {
                    var emanet = new Emanet()
                    {
                        KitapId = (int)kitap?.Id,
                        UyeId = (int)uye?.Id,
                        EmanetTarihi = DateTime.Parse(maskedTxtEmanetTarihi.Text),
                        Teslimtarihi = DateTime.Parse(maskedTxtTeslimTarihi.Text),
                        TeslimDurumu = Convert.ToString(cmbTeslimDurumu.SelectedItem),
                    };

                    _emanetRepo.Add(emanet);                  
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                EmanetListele();
                MessageBox.Show("Ürün Ekleme işlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Ürün Ekleme işlemi Yapılmadı");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Kütüphane veritabanında emanet verileri silinmesin 

            //Emanet seciliEmanet = (Emanet)lstEmanetler.SelectedItem;
            //var emanet = _emanetRepo.GetAll().FirstOrDefault(x => x.Id == seciliEmanet.Id) as Emanet;

            //if (seciliEmanet == null) return;

            //DialogResult cevap = MessageBox.Show("Seçili emaneti silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (cevap == DialogResult.Yes)
            //{
            //    try
            //    {
            //        _emanetRepo.Remove(emanet);
            //        MessageBox.Show("Emanet silme işlemi tamamlandı");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);                  
            //    }
            //    finally
            //    {
            //        EmanetListele();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Emanet silme işlemi yapılmadı");

            //}
        }
        private Emanet seciliEmanet;
        private Uye seciliUyeAdi;
        private void lstEmanetler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmanetler.SelectedItem == null) return; //index çaıştığında null gelebilir. Hata verme.

            seciliEmanet = (Emanet)lstEmanetler.SelectedItem;
            cmbKitapAd.SelectedItem = seciliEmanet.Kitap;
            cmbUyeAdi.SelectedItem = seciliEmanet.Uye;
            maskedTxtEmanetTarihi.Text = seciliEmanet.EmanetTarihi.ToString();
            maskedTxtTeslimTarihi.Text = seciliEmanet.Teslimtarihi.ToString();
            cmbTeslimDurumu.SelectedItem = seciliEmanet.TeslimDurumu;

        }

        private Kitap seciliKitap;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKitapAd.Text) && string.IsNullOrEmpty(cmbUyeAdi.Text)&& string.IsNullOrEmpty(cmbTeslimDurumu.Text))
            {
                MessageBox.Show("Kitap Adı, Uye Adı ve teslim durumu alanları boş geçilemez.");
                return;
            }

            Emanet seciliEmanet = (Emanet)lstEmanetler.SelectedItem;

            if (seciliEmanet == null) return;

            if (cmbKitapAd.SelectedItem != null)
            {
                seciliKitap = (Kitap)cmbKitapAd.SelectedItem;
            }
            else
            {
                seciliKitap = null; return;
            }
            if (cmbUyeAdi.SelectedItem != null)
            {
                seciliUyeAdi = (Uye)cmbUyeAdi.SelectedItem;
            }
            else
            {
                seciliUyeAdi = null; return;
            }
            if (cmbTeslimDurumu.SelectedItem != null)
            {
                seciliEmanet.TeslimDurumu = cmbTeslimDurumu.SelectedItem.ToString();
            }
            else
            {
                seciliEmanet.TeslimDurumu = null; return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Seçili emanet bilgilerini güncellemek istiyor musunuz?", "Emanet Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //var urun = _urunRepo.GetAll().First(x => x.Id == seciliUrun.Id);
                    var emanet = _emanetRepo.GetById(seciliEmanet.Id);

                    emanet.Teslimtarihi=Convert.ToDateTime(maskedTxtTeslimTarihi.Text);
                    emanet.EmanetTarihi = Convert.ToDateTime(maskedTxtEmanetTarihi.Text);
                    _emanetRepo.Update(emanet);
                }
                else
                {
                    MessageBox.Show("Emanet Güncelleme İşlemi Yapılmadı");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Adı, Uye Adı ve teslim durumu alanları boş geçilemez.");
            }
            finally
            {
                EmanetListele();
                MessageBox.Show("Emanet Güncelleme İşlemi Yapıldı");
            }

        }
    }
}
