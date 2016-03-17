using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace K_NN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int komsusay;
        int x1, y1;
        veritabani vt = new veritabani();
        oklit o = new oklit();
        manhattan m = new manhattan();
        minkovski mi = new minkovski();
        siralama s = new siralama();
        private void button1_Click(object sender, EventArgs e)
        {
            komsusay = Convert.ToInt16(textBox1.Text);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt16(textBox2.Text);
            y1 = Convert.ToInt16(textBox3.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                object[,] veriseti= verileriget();
                double[,] sonuclar=o.uzaklikbagintisi(veriseti, x1, y1);
                sonuclar= s.bubble_sort(sonuclar);
                komsu ko = new komsu();
                ko.komsularget(komsusay, sonuclar, veriseti, x1, y1);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                object[,] veriseti = verileriget();
                double[,] sonuclar = m.uzaklikbagintisi(veriseti, x1, y1);
                sonuclar = s.bubble_sort(sonuclar);
                komsu ko = new komsu();
                ko.komsularget(komsusay, sonuclar, veriseti, x1, y1);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                object[,] veriseti = verileriget();
                double[,] sonuclar = mi.uzaklikbagintisi(veriseti, x1, y1);
                sonuclar = s.bubble_sort(sonuclar);
                komsu ko = new komsu();
                ko.komsularget(komsusay, sonuclar, veriseti, x1, y1);
            }
        }
        
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Buruk\Desktop\Kitap1.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");

            public object[,] verileriget()
            {
                object[,] veriseti=new object[10,3];
                baglanti.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", baglanti);
                DataTable dt = new DataTable();

                da.Fill(dt);
                DataTable daa = dt;
                dataGridView1.DataSource = dt.DefaultView;

                for (int i = 0; i < dt.DefaultView.Count; i++)
                {


                    veriseti[i, 0] = dataGridView1[0, i].Value.ToString();
                    veriseti[i, 1] = dataGridView1[1, i].Value.ToString();
                     veriseti[i, 2] = dataGridView1[2, i].Value.ToString();
                }
                baglanti.Close();
                return veriseti;
            }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
