using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsFirmasıBiletUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobüs.Text)
            {
                case "Travego":
                    KoltukDoldur(8, false, false);
                    break;
                case "MAN":
                    KoltukDoldur(10, true, false);
                    break;
                case "Mercedes - Benz":
                    KoltukDoldur(11, false, false);
                    break;
                case "EfeTUR":
                    KoltukDoldur(12, false, true);
                    break;

            }
            void KoltukDoldur(int sira, bool arkaBeslimi, bool tekli)
            {
            yavaslat:
                foreach (Control ctrl in this.Controls)
                {

                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;

                        }
                    }
                }
                int koltukNo = 1;

                for (int i = 0; i < sira; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (tekli == true)
                        {
                            if (j == 1)
                            {
                                continue;
                            }
                        }

                        if (i == sira / 2 && j > 2)
                        {
                            continue;
                        }

                        if (arkaBeslimi == true)
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (j == 2)
                            {
                                continue;
                            }

                        }


                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = ContextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;

                        this.Controls.Add(koltuk);
                    }
                }
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudFiyat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobüs.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz.");
                return; // else açamaya gerek kalmadı

            }

            KayıtFormu kf = new KayıtFormu();
            DialogResult sonuc = kf.ShowDialog();  // form ekrenını getirir

            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}", kf.txtIsim.Text, kf.txtSoyisim.Text);
                lvi.SubItems.Add(kf.mskdTelefon.Text);
                if (kf.rdbBay.Checked)
                {
                    lvi.SubItems.Add("BAY");
                    tiklanan.BackColor = Color.Blue;
                }
                if(kf.rdbBayan.Checked)
                {
                    lvi.SubItems.Add("BAYAN");
                    tiklanan.BackColor = Color.Red;
                }
                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(cmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                lvi.SubItems.Add(nudFiyat.Value.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
