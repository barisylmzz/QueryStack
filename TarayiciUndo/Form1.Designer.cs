namespace TarayiciUndo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSayfaGir = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblAcilacakSayfa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 503);
            this.listBox1.TabIndex = 0;
            // 
            // btnSayfaGir
            // 
            this.btnSayfaGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayfaGir.Location = new System.Drawing.Point(273, 12);
            this.btnSayfaGir.Name = "btnSayfaGir";
            this.btnSayfaGir.Size = new System.Drawing.Size(152, 39);
            this.btnSayfaGir.TabIndex = 1;
            this.btnSayfaGir.Text = "Geçmişe Ekle";
            this.btnSayfaGir.UseVisualStyleBackColor = true;
            this.btnSayfaGir.Click += new System.EventHandler(this.btnSayfaGir_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrl.Location = new System.Drawing.Point(450, 12);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(441, 39);
            this.txtUrl.TabIndex = 2;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUndo.Location = new System.Drawing.Point(273, 97);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(152, 44);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Geri Dön";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblAcilacakSayfa
            // 
            this.lblAcilacakSayfa.AutoSize = true;
            this.lblAcilacakSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcilacakSayfa.Location = new System.Drawing.Point(466, 111);
            this.lblAcilacakSayfa.Name = "lblAcilacakSayfa";
            this.lblAcilacakSayfa.Size = new System.Drawing.Size(156, 25);
            this.lblAcilacakSayfa.TabIndex = 4;
            this.lblAcilacakSayfa.Text = "Açılacak Sayfa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 503);
            this.Controls.Add(this.lblAcilacakSayfa);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnSayfaGir);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSayfaGir;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblAcilacakSayfa;
    }
}

