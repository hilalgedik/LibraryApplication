namespace BookThingsApp
{
    partial class BookThingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.tbxKitap_Turu = new System.Windows.Forms.TextBox();
            this.lblKitap_Turu = new System.Windows.Forms.Label();
            this.tbxKitap_SayfaSayisi = new System.Windows.Forms.TextBox();
            this.lblKitap_SayfaSayisi = new System.Windows.Forms.Label();
            this.tbxKitap_Adedi = new System.Windows.Forms.TextBox();
            this.tbxBaskiNo = new System.Windows.Forms.TextBox();
            this.tbxBasimTarihi = new System.Windows.Forms.TextBox();
            this.tbxYayinevi = new System.Windows.Forms.TextBox();
            this.tbxYazar = new System.Windows.Forms.TextBox();
            this.tbxKitap_Adi = new System.Windows.Forms.TextBox();
            this.lblKitap_Adedi = new System.Windows.Forms.Label();
            this.lblBaskiNo = new System.Windows.Forms.Label();
            this.lblBasimTarihi = new System.Windows.Forms.Label();
            this.lblYayınevi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKitap_Adi = new System.Windows.Forms.Label();
            this.updateKitapBtn = new System.Windows.Forms.Button();
            this.deleteKitapBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.dgwBookThings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookThings)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(964, 438);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(128, 42);
            this.exitBtn.TabIndex = 83;
            this.exitBtn.Text = "Çıkış";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(967, 360);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(125, 42);
            this.clearBtn.TabIndex = 82;
            this.clearBtn.Text = "Temizle";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // tbxKitap_Turu
            // 
            this.tbxKitap_Turu.Location = new System.Drawing.Point(883, 311);
            this.tbxKitap_Turu.Name = "tbxKitap_Turu";
            this.tbxKitap_Turu.Size = new System.Drawing.Size(202, 27);
            this.tbxKitap_Turu.TabIndex = 75;
            // 
            // lblKitap_Turu
            // 
            this.lblKitap_Turu.AutoSize = true;
            this.lblKitap_Turu.Location = new System.Drawing.Point(719, 314);
            this.lblKitap_Turu.Name = "lblKitap_Turu";
            this.lblKitap_Turu.Size = new System.Drawing.Size(77, 20);
            this.lblKitap_Turu.TabIndex = 74;
            this.lblKitap_Turu.Text = "Kitap Türü";
            // 
            // tbxKitap_SayfaSayisi
            // 
            this.tbxKitap_SayfaSayisi.Location = new System.Drawing.Point(883, 271);
            this.tbxKitap_SayfaSayisi.Name = "tbxKitap_SayfaSayisi";
            this.tbxKitap_SayfaSayisi.Size = new System.Drawing.Size(202, 27);
            this.tbxKitap_SayfaSayisi.TabIndex = 73;
            // 
            // lblKitap_SayfaSayisi
            // 
            this.lblKitap_SayfaSayisi.AutoSize = true;
            this.lblKitap_SayfaSayisi.Location = new System.Drawing.Point(719, 274);
            this.lblKitap_SayfaSayisi.Name = "lblKitap_SayfaSayisi";
            this.lblKitap_SayfaSayisi.Size = new System.Drawing.Size(125, 20);
            this.lblKitap_SayfaSayisi.TabIndex = 72;
            this.lblKitap_SayfaSayisi.Text = "Kitap Sayfa Sayısı";
            // 
            // tbxKitap_Adedi
            // 
            this.tbxKitap_Adedi.Location = new System.Drawing.Point(883, 226);
            this.tbxKitap_Adedi.Name = "tbxKitap_Adedi";
            this.tbxKitap_Adedi.Size = new System.Drawing.Size(202, 27);
            this.tbxKitap_Adedi.TabIndex = 71;
            // 
            // tbxBaskiNo
            // 
            this.tbxBaskiNo.Location = new System.Drawing.Point(883, 186);
            this.tbxBaskiNo.Name = "tbxBaskiNo";
            this.tbxBaskiNo.Size = new System.Drawing.Size(202, 27);
            this.tbxBaskiNo.TabIndex = 70;
            // 
            // tbxBasimTarihi
            // 
            this.tbxBasimTarihi.Location = new System.Drawing.Point(883, 145);
            this.tbxBasimTarihi.Name = "tbxBasimTarihi";
            this.tbxBasimTarihi.Size = new System.Drawing.Size(202, 27);
            this.tbxBasimTarihi.TabIndex = 69;
            // 
            // tbxYayinevi
            // 
            this.tbxYayinevi.Location = new System.Drawing.Point(883, 102);
            this.tbxYayinevi.Name = "tbxYayinevi";
            this.tbxYayinevi.Size = new System.Drawing.Size(202, 27);
            this.tbxYayinevi.TabIndex = 68;
            // 
            // tbxYazar
            // 
            this.tbxYazar.Location = new System.Drawing.Point(883, 63);
            this.tbxYazar.Name = "tbxYazar";
            this.tbxYazar.Size = new System.Drawing.Size(202, 27);
            this.tbxYazar.TabIndex = 67;
            // 
            // tbxKitap_Adi
            // 
            this.tbxKitap_Adi.Location = new System.Drawing.Point(883, 23);
            this.tbxKitap_Adi.Name = "tbxKitap_Adi";
            this.tbxKitap_Adi.Size = new System.Drawing.Size(202, 27);
            this.tbxKitap_Adi.TabIndex = 66;
            // 
            // lblKitap_Adedi
            // 
            this.lblKitap_Adedi.AutoSize = true;
            this.lblKitap_Adedi.Location = new System.Drawing.Point(719, 229);
            this.lblKitap_Adedi.Name = "lblKitap_Adedi";
            this.lblKitap_Adedi.Size = new System.Drawing.Size(88, 20);
            this.lblKitap_Adedi.TabIndex = 65;
            this.lblKitap_Adedi.Text = "Kitap Adedi";
            // 
            // lblBaskiNo
            // 
            this.lblBaskiNo.AutoSize = true;
            this.lblBaskiNo.Location = new System.Drawing.Point(719, 189);
            this.lblBaskiNo.Name = "lblBaskiNo";
            this.lblBaskiNo.Size = new System.Drawing.Size(110, 20);
            this.lblBaskiNo.TabIndex = 64;
            this.lblBaskiNo.Text = "Baskı Numarası";
            // 
            // lblBasimTarihi
            // 
            this.lblBasimTarihi.AutoSize = true;
            this.lblBasimTarihi.Location = new System.Drawing.Point(719, 148);
            this.lblBasimTarihi.Name = "lblBasimTarihi";
            this.lblBasimTarihi.Size = new System.Drawing.Size(88, 20);
            this.lblBasimTarihi.TabIndex = 63;
            this.lblBasimTarihi.Text = "Basım Tarihi";
            // 
            // lblYayınevi
            // 
            this.lblYayınevi.AutoSize = true;
            this.lblYayınevi.Location = new System.Drawing.Point(719, 109);
            this.lblYayınevi.Name = "lblYayınevi";
            this.lblYayınevi.Size = new System.Drawing.Size(62, 20);
            this.lblYayınevi.TabIndex = 62;
            this.lblYayınevi.Text = "Yayınevi";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(719, 66);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(44, 20);
            this.lblYazar.TabIndex = 61;
            this.lblYazar.Text = "Yazar";
            // 
            // lblKitap_Adi
            // 
            this.lblKitap_Adi.AutoSize = true;
            this.lblKitap_Adi.Location = new System.Drawing.Point(719, 26);
            this.lblKitap_Adi.Name = "lblKitap_Adi";
            this.lblKitap_Adi.Size = new System.Drawing.Size(71, 20);
            this.lblKitap_Adi.TabIndex = 60;
            this.lblKitap_Adi.Text = "Kitap Adı";
            // 
            // updateKitapBtn
            // 
            this.updateKitapBtn.Location = new System.Drawing.Point(470, 441);
            this.updateKitapBtn.Name = "updateKitapBtn";
            this.updateKitapBtn.Size = new System.Drawing.Size(176, 39);
            this.updateKitapBtn.TabIndex = 59;
            this.updateKitapBtn.Text = "Kitap Güncelle";
            this.updateKitapBtn.UseVisualStyleBackColor = true;
            this.updateKitapBtn.Click += new System.EventHandler(this.updateKitapBtn_Click);
            // 
            // deleteKitapBtn
            // 
            this.deleteKitapBtn.Location = new System.Drawing.Point(257, 439);
            this.deleteKitapBtn.Name = "deleteKitapBtn";
            this.deleteKitapBtn.Size = new System.Drawing.Size(144, 41);
            this.deleteKitapBtn.TabIndex = 58;
            this.deleteKitapBtn.Text = "Kitap Sil";
            this.deleteKitapBtn.UseVisualStyleBackColor = true;
            this.deleteKitapBtn.Click += new System.EventHandler(this.deleteKitapBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(37, 438);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(142, 42);
            this.addBookBtn.TabIndex = 57;
            this.addBookBtn.Text = "Kitap Ekle";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // dgwBookThings
            // 
            this.dgwBookThings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookThings.Location = new System.Drawing.Point(22, 23);
            this.dgwBookThings.Name = "dgwBookThings";
            this.dgwBookThings.RowHeadersWidth = 51;
            this.dgwBookThings.RowTemplate.Height = 29;
            this.dgwBookThings.Size = new System.Drawing.Size(637, 395);
            this.dgwBookThings.TabIndex = 56;
            this.dgwBookThings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookThings_CellClick);
            // 
            // BookThingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 507);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.tbxKitap_Turu);
            this.Controls.Add(this.lblKitap_Turu);
            this.Controls.Add(this.tbxKitap_SayfaSayisi);
            this.Controls.Add(this.lblKitap_SayfaSayisi);
            this.Controls.Add(this.tbxKitap_Adedi);
            this.Controls.Add(this.tbxBaskiNo);
            this.Controls.Add(this.tbxBasimTarihi);
            this.Controls.Add(this.tbxYayinevi);
            this.Controls.Add(this.tbxYazar);
            this.Controls.Add(this.tbxKitap_Adi);
            this.Controls.Add(this.lblKitap_Adedi);
            this.Controls.Add(this.lblBaskiNo);
            this.Controls.Add(this.lblBasimTarihi);
            this.Controls.Add(this.lblYayınevi);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitap_Adi);
            this.Controls.Add(this.updateKitapBtn);
            this.Controls.Add(this.deleteKitapBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.dgwBookThings);
            this.Name = "BookThingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookThingsApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookThings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitBtn;
        private Button clearBtn;
        private TextBox tbxKitap_Turu;
        private Label lblKitap_Turu;
        private TextBox tbxKitap_SayfaSayisi;
        private Label lblKitap_SayfaSayisi;
        private TextBox tbxKitap_Adedi;
        private TextBox tbxBaskiNo;
        private TextBox tbxBasimTarihi;
        private TextBox tbxYayinevi;
        private TextBox tbxYazar;
        private TextBox tbxKitap_Adi;
        private Label lblKitap_Adedi;
        private Label lblBaskiNo;
        private Label lblBasimTarihi;
        private Label lblYayınevi;
        private Label lblYazar;
        private Label lblKitap_Adi;
        private Button updateKitapBtn;
        private Button deleteKitapBtn;
        private Button addBookBtn;
        private DataGridView dgwBookThings;
    }
}