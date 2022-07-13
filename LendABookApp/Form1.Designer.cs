namespace LendABookApp
{
    partial class LendABookForm
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
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.dgwMemberList = new System.Windows.Forms.DataGridView();
            this.dgwLendedBookList = new System.Windows.Forms.DataGridView();
            this.lblKitap_Id = new System.Windows.Forms.Label();
            this.lblKitap_Adi = new System.Windows.Forms.Label();
            this.tbxKitap_Id = new System.Windows.Forms.TextBox();
            this.tbxKitap_Adi = new System.Windows.Forms.TextBox();
            this.lblUye_Id = new System.Windows.Forms.Label();
            this.lblUye_Isim = new System.Windows.Forms.Label();
            this.lblUye_Soyisim = new System.Windows.Forms.Label();
            this.lblUye_TelNo = new System.Windows.Forms.Label();
            this.tbxUye_Id = new System.Windows.Forms.TextBox();
            this.tbxUye_Isim = new System.Windows.Forms.TextBox();
            this.tbxUye_Soyisim = new System.Windows.Forms.TextBox();
            this.tbxUye_TelNo = new System.Windows.Forms.TextBox();
            this.lblKitap_IdLended = new System.Windows.Forms.Label();
            this.tbxKitap_IdLended = new System.Windows.Forms.TextBox();
            this.tbxUye_IdLended = new System.Windows.Forms.TextBox();
            this.lblUye_IdLended = new System.Windows.Forms.Label();
            this.lblKitap_AdiLended = new System.Windows.Forms.Label();
            this.tbxKitap_AdiLended = new System.Windows.Forms.TextBox();
            this.lblUye_İsimLended = new System.Windows.Forms.Label();
            this.tbxUye_IsimLended = new System.Windows.Forms.TextBox();
            this.lblUye_SoyisimLended = new System.Windows.Forms.Label();
            this.tbxUye_SoyisimLended = new System.Windows.Forms.TextBox();
            this.lblUye_TelNoLended = new System.Windows.Forms.Label();
            this.tbxUye_TelNoLended = new System.Windows.Forms.TextBox();
            this.lblKitap_AdediLended = new System.Windows.Forms.Label();
            this.tbxKitap_AdediLended = new System.Windows.Forms.TextBox();
            this.btnLended = new System.Windows.Forms.Button();
            this.btnLendedUpdate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCleanMember = new System.Windows.Forms.Button();
            this.btnCleanBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendedBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBookList
            // 
            this.dgwBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookList.Location = new System.Drawing.Point(12, 12);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 29;
            this.dgwBookList.Size = new System.Drawing.Size(451, 242);
            this.dgwBookList.TabIndex = 0;
            this.dgwBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookList_CellClick);
            // 
            // dgwMemberList
            // 
            this.dgwMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMemberList.Location = new System.Drawing.Point(494, 12);
            this.dgwMemberList.Name = "dgwMemberList";
            this.dgwMemberList.RowHeadersWidth = 51;
            this.dgwMemberList.RowTemplate.Height = 29;
            this.dgwMemberList.Size = new System.Drawing.Size(453, 242);
            this.dgwMemberList.TabIndex = 1;
            this.dgwMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMemberList_CellClick);
            // 
            // dgwLendedBookList
            // 
            this.dgwLendedBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLendedBookList.Location = new System.Drawing.Point(991, 12);
            this.dgwLendedBookList.Name = "dgwLendedBookList";
            this.dgwLendedBookList.RowHeadersWidth = 51;
            this.dgwLendedBookList.RowTemplate.Height = 29;
            this.dgwLendedBookList.Size = new System.Drawing.Size(417, 242);
            this.dgwLendedBookList.TabIndex = 2;
            // 
            // lblKitap_Id
            // 
            this.lblKitap_Id.AutoSize = true;
            this.lblKitap_Id.Location = new System.Drawing.Point(24, 304);
            this.lblKitap_Id.Name = "lblKitap_Id";
            this.lblKitap_Id.Size = new System.Drawing.Size(63, 20);
            this.lblKitap_Id.TabIndex = 3;
            this.lblKitap_Id.Text = "Kitap ID";
            // 
            // lblKitap_Adi
            // 
            this.lblKitap_Adi.AutoSize = true;
            this.lblKitap_Adi.Location = new System.Drawing.Point(24, 355);
            this.lblKitap_Adi.Name = "lblKitap_Adi";
            this.lblKitap_Adi.Size = new System.Drawing.Size(71, 20);
            this.lblKitap_Adi.TabIndex = 4;
            this.lblKitap_Adi.Text = "Kitap Adı";
            // 
            // tbxKitap_Id
            // 
            this.tbxKitap_Id.Location = new System.Drawing.Point(133, 301);
            this.tbxKitap_Id.Name = "tbxKitap_Id";
            this.tbxKitap_Id.Size = new System.Drawing.Size(330, 27);
            this.tbxKitap_Id.TabIndex = 5;
            // 
            // tbxKitap_Adi
            // 
            this.tbxKitap_Adi.Location = new System.Drawing.Point(133, 355);
            this.tbxKitap_Adi.Name = "tbxKitap_Adi";
            this.tbxKitap_Adi.Size = new System.Drawing.Size(330, 27);
            this.tbxKitap_Adi.TabIndex = 6;
            // 
            // lblUye_Id
            // 
            this.lblUye_Id.AutoSize = true;
            this.lblUye_Id.Location = new System.Drawing.Point(506, 301);
            this.lblUye_Id.Name = "lblUye_Id";
            this.lblUye_Id.Size = new System.Drawing.Size(53, 20);
            this.lblUye_Id.TabIndex = 7;
            this.lblUye_Id.Text = "Üye ID";
            // 
            // lblUye_Isim
            // 
            this.lblUye_Isim.AutoSize = true;
            this.lblUye_Isim.Location = new System.Drawing.Point(506, 344);
            this.lblUye_Isim.Name = "lblUye_Isim";
            this.lblUye_Isim.Size = new System.Drawing.Size(65, 20);
            this.lblUye_Isim.TabIndex = 8;
            this.lblUye_Isim.Text = "Üye İsim";
            // 
            // lblUye_Soyisim
            // 
            this.lblUye_Soyisim.AutoSize = true;
            this.lblUye_Soyisim.Location = new System.Drawing.Point(506, 389);
            this.lblUye_Soyisim.Name = "lblUye_Soyisim";
            this.lblUye_Soyisim.Size = new System.Drawing.Size(89, 20);
            this.lblUye_Soyisim.TabIndex = 9;
            this.lblUye_Soyisim.Text = "Üye Soyisim";
            // 
            // lblUye_TelNo
            // 
            this.lblUye_TelNo.AutoSize = true;
            this.lblUye_TelNo.Location = new System.Drawing.Point(506, 429);
            this.lblUye_TelNo.Name = "lblUye_TelNo";
            this.lblUye_TelNo.Size = new System.Drawing.Size(111, 20);
            this.lblUye_TelNo.TabIndex = 10;
            this.lblUye_TelNo.Text = "Üye Telefon No";
            // 
            // tbxUye_Id
            // 
            this.tbxUye_Id.Location = new System.Drawing.Point(625, 298);
            this.tbxUye_Id.Name = "tbxUye_Id";
            this.tbxUye_Id.Size = new System.Drawing.Size(322, 27);
            this.tbxUye_Id.TabIndex = 11;
            // 
            // tbxUye_Isim
            // 
            this.tbxUye_Isim.Location = new System.Drawing.Point(625, 344);
            this.tbxUye_Isim.Name = "tbxUye_Isim";
            this.tbxUye_Isim.Size = new System.Drawing.Size(322, 27);
            this.tbxUye_Isim.TabIndex = 12;
            // 
            // tbxUye_Soyisim
            // 
            this.tbxUye_Soyisim.Location = new System.Drawing.Point(625, 389);
            this.tbxUye_Soyisim.Name = "tbxUye_Soyisim";
            this.tbxUye_Soyisim.Size = new System.Drawing.Size(322, 27);
            this.tbxUye_Soyisim.TabIndex = 13;
            // 
            // tbxUye_TelNo
            // 
            this.tbxUye_TelNo.Location = new System.Drawing.Point(625, 429);
            this.tbxUye_TelNo.Name = "tbxUye_TelNo";
            this.tbxUye_TelNo.Size = new System.Drawing.Size(322, 27);
            this.tbxUye_TelNo.TabIndex = 14;
            // 
            // lblKitap_IdLended
            // 
            this.lblKitap_IdLended.AutoSize = true;
            this.lblKitap_IdLended.Location = new System.Drawing.Point(1013, 277);
            this.lblKitap_IdLended.Name = "lblKitap_IdLended";
            this.lblKitap_IdLended.Size = new System.Drawing.Size(63, 20);
            this.lblKitap_IdLended.TabIndex = 15;
            this.lblKitap_IdLended.Text = "Kitap ID";
            // 
            // tbxKitap_IdLended
            // 
            this.tbxKitap_IdLended.Location = new System.Drawing.Point(1163, 274);
            this.tbxKitap_IdLended.Name = "tbxKitap_IdLended";
            this.tbxKitap_IdLended.Size = new System.Drawing.Size(245, 27);
            this.tbxKitap_IdLended.TabIndex = 16;
            // 
            // tbxUye_IdLended
            // 
            this.tbxUye_IdLended.Location = new System.Drawing.Point(1163, 307);
            this.tbxUye_IdLended.Name = "tbxUye_IdLended";
            this.tbxUye_IdLended.Size = new System.Drawing.Size(245, 27);
            this.tbxUye_IdLended.TabIndex = 17;
            // 
            // lblUye_IdLended
            // 
            this.lblUye_IdLended.AutoSize = true;
            this.lblUye_IdLended.Location = new System.Drawing.Point(1013, 310);
            this.lblUye_IdLended.Name = "lblUye_IdLended";
            this.lblUye_IdLended.Size = new System.Drawing.Size(53, 20);
            this.lblUye_IdLended.TabIndex = 18;
            this.lblUye_IdLended.Text = "Üye ID";
            // 
            // lblKitap_AdiLended
            // 
            this.lblKitap_AdiLended.AutoSize = true;
            this.lblKitap_AdiLended.Location = new System.Drawing.Point(1013, 340);
            this.lblKitap_AdiLended.Name = "lblKitap_AdiLended";
            this.lblKitap_AdiLended.Size = new System.Drawing.Size(71, 20);
            this.lblKitap_AdiLended.TabIndex = 20;
            this.lblKitap_AdiLended.Text = "Kitap Adi";
            // 
            // tbxKitap_AdiLended
            // 
            this.tbxKitap_AdiLended.Location = new System.Drawing.Point(1163, 337);
            this.tbxKitap_AdiLended.Name = "tbxKitap_AdiLended";
            this.tbxKitap_AdiLended.Size = new System.Drawing.Size(245, 27);
            this.tbxKitap_AdiLended.TabIndex = 19;
            // 
            // lblUye_İsimLended
            // 
            this.lblUye_İsimLended.AutoSize = true;
            this.lblUye_İsimLended.Location = new System.Drawing.Point(1013, 378);
            this.lblUye_İsimLended.Name = "lblUye_İsimLended";
            this.lblUye_İsimLended.Size = new System.Drawing.Size(65, 20);
            this.lblUye_İsimLended.TabIndex = 22;
            this.lblUye_İsimLended.Text = "Üye İsim";
            // 
            // tbxUye_IsimLended
            // 
            this.tbxUye_IsimLended.Location = new System.Drawing.Point(1163, 375);
            this.tbxUye_IsimLended.Name = "tbxUye_IsimLended";
            this.tbxUye_IsimLended.Size = new System.Drawing.Size(245, 27);
            this.tbxUye_IsimLended.TabIndex = 21;
            // 
            // lblUye_SoyisimLended
            // 
            this.lblUye_SoyisimLended.AutoSize = true;
            this.lblUye_SoyisimLended.Location = new System.Drawing.Point(1013, 412);
            this.lblUye_SoyisimLended.Name = "lblUye_SoyisimLended";
            this.lblUye_SoyisimLended.Size = new System.Drawing.Size(89, 20);
            this.lblUye_SoyisimLended.TabIndex = 24;
            this.lblUye_SoyisimLended.Text = "Üye Soyisim";
            // 
            // tbxUye_SoyisimLended
            // 
            this.tbxUye_SoyisimLended.Location = new System.Drawing.Point(1163, 409);
            this.tbxUye_SoyisimLended.Name = "tbxUye_SoyisimLended";
            this.tbxUye_SoyisimLended.Size = new System.Drawing.Size(245, 27);
            this.tbxUye_SoyisimLended.TabIndex = 23;
            // 
            // lblUye_TelNoLended
            // 
            this.lblUye_TelNoLended.AutoSize = true;
            this.lblUye_TelNoLended.Location = new System.Drawing.Point(1013, 448);
            this.lblUye_TelNoLended.Name = "lblUye_TelNoLended";
            this.lblUye_TelNoLended.Size = new System.Drawing.Size(111, 20);
            this.lblUye_TelNoLended.TabIndex = 26;
            this.lblUye_TelNoLended.Text = "Üye Telefon No";
            // 
            // tbxUye_TelNoLended
            // 
            this.tbxUye_TelNoLended.Location = new System.Drawing.Point(1163, 445);
            this.tbxUye_TelNoLended.Name = "tbxUye_TelNoLended";
            this.tbxUye_TelNoLended.Size = new System.Drawing.Size(245, 27);
            this.tbxUye_TelNoLended.TabIndex = 25;
            // 
            // lblKitap_AdediLended
            // 
            this.lblKitap_AdediLended.AutoSize = true;
            this.lblKitap_AdediLended.Location = new System.Drawing.Point(1013, 486);
            this.lblKitap_AdediLended.Name = "lblKitap_AdediLended";
            this.lblKitap_AdediLended.Size = new System.Drawing.Size(88, 20);
            this.lblKitap_AdediLended.TabIndex = 28;
            this.lblKitap_AdediLended.Text = "Kitap Adedi";
            // 
            // tbxKitap_AdediLended
            // 
            this.tbxKitap_AdediLended.Location = new System.Drawing.Point(1163, 483);
            this.tbxKitap_AdediLended.Name = "tbxKitap_AdediLended";
            this.tbxKitap_AdediLended.Size = new System.Drawing.Size(245, 27);
            this.tbxKitap_AdediLended.TabIndex = 27;
            // 
            // btnLended
            // 
            this.btnLended.Location = new System.Drawing.Point(12, 507);
            this.btnLended.Name = "btnLended";
            this.btnLended.Size = new System.Drawing.Size(272, 66);
            this.btnLended.TabIndex = 29;
            this.btnLended.Text = "Ödünç Ver";
            this.btnLended.UseVisualStyleBackColor = true;
            this.btnLended.Click += new System.EventHandler(this.btnLended_Click);
            // 
            // btnLendedUpdate
            // 
            this.btnLendedUpdate.Location = new System.Drawing.Point(580, 507);
            this.btnLendedUpdate.Name = "btnLendedUpdate";
            this.btnLendedUpdate.Size = new System.Drawing.Size(272, 66);
            this.btnLendedUpdate.TabIndex = 30;
            this.btnLendedUpdate.Text = "Güncelle";
            this.btnLendedUpdate.UseVisualStyleBackColor = true;

            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(1331, 521);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(77, 39);
            this.btnClean.TabIndex = 31;
            this.btnClean.Text = "Temizle";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCleanMember
            // 
            this.btnCleanMember.Location = new System.Drawing.Point(853, 462);
            this.btnCleanMember.Name = "btnCleanMember";
            this.btnCleanMember.Size = new System.Drawing.Size(94, 29);
            this.btnCleanMember.TabIndex = 32;
            this.btnCleanMember.Text = "Temizle";
            this.btnCleanMember.UseVisualStyleBackColor = true;
            this.btnCleanMember.Click += new System.EventHandler(this.btnCleanMember_Click);
            // 
            // btnCleanBook
            // 
            this.btnCleanBook.Location = new System.Drawing.Point(369, 403);
            this.btnCleanBook.Name = "btnCleanBook";
            this.btnCleanBook.Size = new System.Drawing.Size(94, 29);
            this.btnCleanBook.TabIndex = 33;
            this.btnCleanBook.Text = "Temizle";
            this.btnCleanBook.UseVisualStyleBackColor = true;
            this.btnCleanBook.Click += new System.EventHandler(this.btnCleanBook_Click);
            // 
            // LendABookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 599);
            this.Controls.Add(this.btnCleanBook);
            this.Controls.Add(this.btnCleanMember);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnLendedUpdate);
            this.Controls.Add(this.btnLended);
            this.Controls.Add(this.lblKitap_AdediLended);
            this.Controls.Add(this.tbxKitap_AdediLended);
            this.Controls.Add(this.lblUye_TelNoLended);
            this.Controls.Add(this.tbxUye_TelNoLended);
            this.Controls.Add(this.lblUye_SoyisimLended);
            this.Controls.Add(this.tbxUye_SoyisimLended);
            this.Controls.Add(this.lblUye_İsimLended);
            this.Controls.Add(this.tbxUye_IsimLended);
            this.Controls.Add(this.lblKitap_AdiLended);
            this.Controls.Add(this.tbxKitap_AdiLended);
            this.Controls.Add(this.lblUye_IdLended);
            this.Controls.Add(this.tbxUye_IdLended);
            this.Controls.Add(this.tbxKitap_IdLended);
            this.Controls.Add(this.lblKitap_IdLended);
            this.Controls.Add(this.tbxUye_TelNo);
            this.Controls.Add(this.tbxUye_Soyisim);
            this.Controls.Add(this.tbxUye_Isim);
            this.Controls.Add(this.tbxUye_Id);
            this.Controls.Add(this.lblUye_TelNo);
            this.Controls.Add(this.lblUye_Soyisim);
            this.Controls.Add(this.lblUye_Isim);
            this.Controls.Add(this.lblUye_Id);
            this.Controls.Add(this.tbxKitap_Adi);
            this.Controls.Add(this.tbxKitap_Id);
            this.Controls.Add(this.lblKitap_Adi);
            this.Controls.Add(this.lblKitap_Id);
            this.Controls.Add(this.dgwLendedBookList);
            this.Controls.Add(this.dgwMemberList);
            this.Controls.Add(this.dgwBookList);
            this.Name = "LendABookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LendABookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendedBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgwBookList;
        private DataGridView dgwMemberList;
        private DataGridView dgwLendedBookList;
        private Label lblKitap_Id;
        private Label lblKitap_Adi;
        private TextBox tbxKitap_Id;
        private TextBox tbxKitap_Adi;
        private Label lblUye_Id;
        private Label lblUye_Isim;
        private Label lblUye_Soyisim;
        private Label lblUye_TelNo;
        private TextBox tbxUye_Id;
        private TextBox tbxUye_Isim;
        private TextBox tbxUye_Soyisim;
        private TextBox tbxUye_TelNo;
        private Label lblKitap_IdLended;
        private TextBox tbxKitap_IdLended;
        private TextBox tbxUye_IdLended;
        private Label lblUye_IdLended;
        private Label lblKitap_AdiLended;
        private TextBox tbxKitap_AdiLended;
        private Label lblUye_İsimLended;
        private TextBox tbxUye_IsimLended;
        private Label lblUye_SoyisimLended;
        private TextBox tbxUye_SoyisimLended;
        private Label lblUye_TelNoLended;
        private TextBox tbxUye_TelNoLended;
        private Label lblKitap_AdediLended;
        private TextBox tbxKitap_AdediLended;
        private Button btnLended;
        private Button btnLendedUpdate;
        private Button btnClean;
        private Button btnCleanMember;
        private Button btnCleanBook;
    }
}