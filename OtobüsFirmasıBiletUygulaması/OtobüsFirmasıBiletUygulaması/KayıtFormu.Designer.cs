namespace OtobüsFirmasıBiletUygulaması
{
    partial class KayıtFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(183, 25);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(133, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(183, 61);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(133, 20);
            this.txtSoyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "telefon";
            // 
            // mskdTelefon
            // 
            this.mskdTelefon.Location = new System.Drawing.Point(183, 96);
            this.mskdTelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskdTelefon.Mask = "(999) 000-0000";
            this.mskdTelefon.Name = "mskdTelefon";
            this.mskdTelefon.Size = new System.Drawing.Size(133, 20);
            this.mskdTelefon.TabIndex = 3;
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Checked = true;
            this.rdbBay.Location = new System.Drawing.Point(88, 139);
            this.rdbBay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(46, 17);
            this.rdbBay.TabIndex = 4;
            this.rdbBay.TabStop = true;
            this.rdbBay.Text = "Bay";
            this.rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Location = new System.Drawing.Point(201, 139);
            this.rdbBayan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(60, 17);
            this.rdbBayan.TabIndex = 5;
            this.rdbBayan.Text = "Bayan";
            this.rdbBayan.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(88, 177);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(88, 23);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(201, 177);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(88, 23);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 244);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.rdbBayan);
            this.Controls.Add(this.rdbBay);
            this.Controls.Add(this.mskdTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KayıtFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.TextBox txtIsim;
        public System.Windows.Forms.TextBox txtSoyisim;
        public System.Windows.Forms.MaskedTextBox mskdTelefon;
        public System.Windows.Forms.RadioButton rdbBay;
        public System.Windows.Forms.RadioButton rdbBayan;
    }
}