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

namespace TarayiciUndo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack undo = new Stack();

        private void btnSayfaGir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                undo.Push(txtUrl.Text);
            }
            else
            {
                MessageBox.Show("URL boş bırakılamaz.");
            }
            GecmiseEkle();
            txtUrl.Text = "";
        }

        void GecmiseEkle()
        {
            listBox1.Items.Clear();
            foreach (object item in undo)
            {
                listBox1.Items.Add(item);
            }
            if (undo.Count == 0)
            {
                lblAcilacakSayfa.Text = "Geride gidilecek sayfa yok";
                btnUndo.Enabled = false;
            }
            else
            {               
                lblAcilacakSayfa.Text = undo.Peek().ToString();
            }

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtUrl.Text = undo.Pop().ToString();
            GecmiseEkle();
        }

        
    }
}
