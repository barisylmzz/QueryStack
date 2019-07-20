using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaSira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue sira = new Queue();
        int numara = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sira.Enqueue(numara);
            numara++;
            SirayaEkle();
        }

        void SirayaEkle()
        {
            listBox1.Items.Clear();
            lblBekleyen.Text = "Toplam bekleyen müşteri sayısı = " + sira.Count;
            
            foreach (int item in sira)
            {
                listBox1.Items.Add(item);
            }
            if(sira.Count==0)
            {
                label4.Text = "Bekleyen Yok";
            }
            else
            {
                label4.Text = "İşlem bekleyen no= " + sira.Peek();
            }
        }

        private void btnGise1_Click(object sender, EventArgs e)
        {
            GiseyeYonlendir(txtGise1, 1);
            SirayaEkle();
        }

        private void btnGise2_Click(object sender, EventArgs e)
        {
            GiseyeYonlendir(txtGise2, 2);
            SirayaEkle();
        }

        private void btnGise3_Click(object sender, EventArgs e)
        {
            GiseyeYonlendir(txtGise3, 3);
            SirayaEkle();
        }

        void GiseyeYonlendir(TextBox textbox, int giseNo)
        {
            if(listBox1.Items.Count==0)
            {                
                lblYonlendir.Text = "Sırada bekleyen müşteri yok";                
            }
            else
            {                        
                int siradaki = int.Parse(sira.Dequeue().ToString());
                textbox.Text = siradaki.ToString();
                lblYonlendir.Text = "Sıra " + siradaki + " Lütfen " + giseNo + " nolu gişeye gidiniz.";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
