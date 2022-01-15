
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
    }
}
