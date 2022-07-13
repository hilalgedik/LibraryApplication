namespace TakeBackBookApp
{
    partial class TakeBackBookForm
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
            this.dgwLendedBookList = new System.Windows.Forms.DataGridView();
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.tbxKitap_Adi = new System.Windows.Forms.TextBox();
            this.lblKitap_Adi = new System.Windows.Forms.Label();
            this.lblKitap_Adedi = new System.Windows.Forms.Label();
            this.tbxKitap_Adedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakeBackBook = new System.Windows.Forms.Button();
            this.tbxKitap_Id = new System.Windows.Forms.TextBox();
            this.lblKitap_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendedBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLendedBookList
            // 
            this.dgwLendedBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLendedBookList.Location = new System.Drawing.Point(12, 43);
            this.dgwLendedBookList.Name = "dgwLendedBookList";
            this.dgwLendedBookList.RowHeadersWidth = 51;
            this.dgwLendedBookList.RowTemplate.Height = 29;
            this.dgwLendedBookList.Size = new System.Drawing.Size(526, 263);
            this.dgwLendedBookList.TabIndex = 0;
            this.dgwLendedBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLendedBookList_CellClick);
            // 
            // dgwBookList
            // 
            this.dgwBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookList.Location = new System.Drawing.Point(595, 43);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 29;
            this.dgwBookList.Size = new System.Drawing.Size(536, 263);
            this.dgwBookList.TabIndex = 1;
            // 
            // tbxKitap_Adi
            // 
            this.tbxKitap_Adi.Location = new System.Drawing.Point(212, 371);
            this.tbxKitap_Adi.Name = "tbxKitap_Adi";
            this.tbxKitap_Adi.Size = new System.Drawing.Size(180, 27);
            this.tbxKitap_Adi.TabIndex = 2;
            // 
            // lblKitap_Adi
            // 
            this.lblKitap_Adi.AutoSize = true;
            this.lblKitap_Adi.Location = new System.Drawing.Point(52, 374);
            this.lblKitap_Adi.Name = "lblKitap_Adi";
            this.lblKitap_Adi.Size = new System.Drawing.Size(71, 20);
            this.lblKitap_Adi.TabIndex = 3;
            this.lblKitap_Adi.Text = "Kitap Adı";
            // 
            // lblKitap_Adedi
            // 
            this.lblKitap_Adedi.AutoSize = true;
            this.lblKitap_Adedi.Location = new System.Drawing.Point(52, 417);
            this.lblKitap_Adedi.Name = "lblKitap_Adedi";
            this.lblKitap_Adedi.Size = new System.Drawing.Size(88, 20);
            this.lblKitap_Adedi.TabIndex = 4;
            this.lblKitap_Adedi.Text = "Kitap Adedi";
            // 
            // tbxKitap_Adedi
            // 
            this.tbxKitap_Adedi.Location = new System.Drawing.Point(212, 410);
            this.tbxKitap_Adedi.Name = "tbxKitap_Adedi";
            this.tbxKitap_Adedi.Size = new System.Drawing.Size(180, 27);
            this.tbxKitap_Adedi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ödünç verilen kitaplar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap Listesi";
            // 
            // btnTakeBackBook
            // 
            this.btnTakeBackBook.Location = new System.Drawing.Point(505, 361);
            this.btnTakeBackBook.Name = "btnTakeBackBook";
            this.btnTakeBackBook.Size = new System.Drawing.Size(209, 47);
            this.btnTakeBackBook.TabIndex = 8;
            this.btnTakeBackBook.Text = "Kitabı Geri Al";
            this.btnTakeBackBook.UseVisualStyleBackColor = true;
            this.btnTakeBackBook.Click += new System.EventHandler(this.btnTakeBackBook_Click);
            // 
            // tbxKitap_Id
            // 
            this.tbxKitap_Id.Location = new System.Drawing.Point(212, 329);
            this.tbxKitap_Id.Name = "tbxKitap_Id";
            this.tbxKitap_Id.Size = new System.Drawing.Size(180, 27);
            this.tbxKitap_Id.TabIndex = 9;
            // 
            // lblKitap_Id
            // 
            this.lblKitap_Id.AutoSize = true;
            this.lblKitap_Id.Location = new System.Drawing.Point(52, 332);
            this.lblKitap_Id.Name = "lblKitap_Id";
            this.lblKitap_Id.Size = new System.Drawing.Size(61, 20);
            this.lblKitap_Id.TabIndex = 10;
            this.lblKitap_Id.Text = "Kitap Id";
            // 
            // TakeBackBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 513);
            this.Controls.Add(this.lblKitap_Id);
            this.Controls.Add(this.tbxKitap_Id);
            this.Controls.Add(this.btnTakeBackBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKitap_Adedi);
            this.Controls.Add(this.lblKitap_Adedi);
            this.Controls.Add(this.lblKitap_Adi);
            this.Controls.Add(this.tbxKitap_Adi);
            this.Controls.Add(this.dgwBookList);
            this.Controls.Add(this.dgwLendedBookList);
            this.Name = "TakeBackBookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLendedBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgwLendedBookList;
        private DataGridView dgwBookList;
        private TextBox tbxKitap_Adi;
        private Label lblKitap_Adi;
        private Label lblKitap_Adedi;
        private TextBox tbxKitap_Adedi;
        private Label label1;
        private Label label2;
        private Button btnTakeBackBook;
        private TextBox tbxKitap_Id;
        private Label lblKitap_Id;
    }
}