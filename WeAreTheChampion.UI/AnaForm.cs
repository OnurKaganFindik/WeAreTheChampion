using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampion.DATA;

namespace WeAreTheChampion.UI
{
    public partial class AnaForm : Form
    {
        WeAreTheChampionContext db = new WeAreTheChampionContext();
        public AnaForm()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            //dgvAnaform.DataSource = db.
        }

        private void tsmiTakimlar_Click(object sender, EventArgs e)
        {
            TakimlarForm takimlarForm = new TakimlarForm();
            takimlarForm.ShowDialog();
        }

        private void tsmiRenkler_Click(object sender, EventArgs e)
        {
            RenklerForm renklerForm = new RenklerForm();
            renklerForm.ShowDialog();
        }

        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            OyuncularForm oyuncularForm = new OyuncularForm();
            oyuncularForm.ShowDialog();
        }

        private void btnYeniKarsilasma_Click(object sender, EventArgs e)
        {
            KarsilasmaForm karsilasmaForm = new KarsilasmaForm();
            karsilasmaForm.ShowDialog();

        }
    }
}
