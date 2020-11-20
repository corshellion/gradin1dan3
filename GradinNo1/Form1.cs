using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradinNo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<string> mclist = new List<string>();
        string nama = "";
        double gaji = 0;
        int level = 0;
        string negara = "";
        void countlevel()
        {
            if (level == 1)
            {
                gaji = gaji + 200000;
            }
            if (level == 2)
            {
                gaji = gaji + 500000;
            }
            if (level == 3)
            {
                gaji = gaji + 1000000;
            }
        }
        void countpajak()
        {
            if (negara == "Asia")
            {
                gaji = gaji - (gaji * 0.02);
            }
            if (negara == "Europe")
            {
                gaji = gaji - (gaji * 0.025);
                if (negara == "North America")
                {
                    gaji = gaji - (gaji * 0.03);
                }
            }
           
        }
        private void hitung_Click(object sender, EventArgs e)
        {


            try
            {
                nama = cbnama.Text;
                gaji = Convert.ToInt32(cbgaji.Text);
                level = Convert.ToInt32(cblevel.Text);
                negara = cbnegara.Text;
                if (gaji > 7000000)
                {
                    gaji = gaji + (gaji * 0.1);
                    countlevel();
                    countpajak();

                }
                else if (gaji < 7000000 && gaji > 4000000)
                {
                    gaji = gaji + (gaji * 0.2);
                    countlevel();
                    countpajak();
                }
                else if (gaji < 4000000)
                {
                    gaji = gaji + (gaji * 0.4);
                    countlevel();
                    countpajak();
                }

                gajiakhir.Text = gaji.ToString();
                // history
                listView1.View = View.Details;
                listView1.Columns.Add("Nama");
                listView1.Columns.Add("Gaji");
                listView1.Columns.Add("Negara");
                listView1.Columns.Add("Level");
                listView1.Items.Add(new ListViewItem(new string[] { nama, gaji.ToString(), negara,level.ToString() }));
                listView1.GridLines = true;
                listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

            }
            catch (Exception)
            {
                MessageBox.Show("Silahkan Melengkapi data anda!");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double luassegitiga = 0;
        private void hitung1_Click(object sender, EventArgs e)
        {
            try
            {
                luassegitiga = 0.5 * (Convert.ToDouble(alas.Text) * Convert.ToDouble(tinggi.Text));
                hasil1.Text = luassegitiga.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Silahkan Melengkapi data anda!");
            }
        }
        double luaspersegipanjang = 0;
        private void hitung2_Click(object sender, EventArgs e)
        {
            try
            {
                luaspersegipanjang = (Convert.ToDouble(panjang.Text) * Convert.ToDouble(lebar.Text));
                hasil2.Text = luaspersegipanjang.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Silahkan Melengkapi data anda!");
            }
        }
        double luaslingkaran = 0;
        private void hitung3_Click(object sender, EventArgs e)
        {
            try
            {
                luaslingkaran = 3.14* (Convert.ToDouble(jari.Text) * Convert.ToDouble(jari.Text));
                hasil3.Text = luaslingkaran.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Silahkan Melengkapi data anda!");
            }
        }
    }
}
