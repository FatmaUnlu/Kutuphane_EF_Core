using Kutuphane_EF_Core.Data;
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
    public partial class KutuphaneForm : Form
    {
        public KutuphaneForm()
        {
            InitializeComponent();
        }
        private KutuphaneContext _context;
        private void KutuphaneForm_Load(object sender, EventArgs e)
        {
            _context = new KutuphaneContext();
        }

        private Yazar_Kategori_KayitForm _frmYazarKategori;
        private KitapKayitForm _frmKitapKayit;
        private KisiKayitForm _frmKisiKayit;
        private EmanetForm _frmEmanet;

        private void yazarKategoriKayıtFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmYazarKategori == null || _frmYazarKategori.IsDisposed)
            {
                _frmYazarKategori = new Yazar_Kategori_KayitForm();
            }
            
            _frmYazarKategori.MdiParent = this;
            _frmYazarKategori.WindowState = FormWindowState.Maximized;
            _frmYazarKategori.Show();
        }

        private void kitapKayıtFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKitapKayit == null || _frmKitapKayit.IsDisposed)
            {
                _frmKitapKayit = new KitapKayitForm();
            }

            _frmKitapKayit.MdiParent = this;
            _frmKitapKayit.WindowState = FormWindowState.Maximized;
            _frmKitapKayit.Show();
        }

        private void kişiKayıtFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiKayit == null || _frmKisiKayit.IsDisposed)
            {
                _frmKisiKayit = new KisiKayitForm();
            }

            _frmKisiKayit.MdiParent = this;
            _frmKisiKayit.WindowState = FormWindowState.Maximized;
            _frmKisiKayit.Show();
        }

        private void emanetKitapFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmEmanet == null || _frmEmanet.IsDisposed)
            {
                _frmEmanet = new EmanetForm();
            }

            _frmEmanet.MdiParent = this;
            _frmEmanet.WindowState = FormWindowState.Maximized;
            _frmEmanet.Show();
        }
    }
}
