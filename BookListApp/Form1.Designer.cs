namespace BookListApp
{
    partial class BookListForm
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
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.listBookBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(12, 12);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 29;
            this.dgwBooks.Size = new System.Drawing.Size(776, 254);
            this.dgwBooks.TabIndex = 0;
            // 
            // listBookBtn
            // 
            this.listBookBtn.Location = new System.Drawing.Point(43, 315);
            this.listBookBtn.Name = "listBookBtn";
            this.listBookBtn.Size = new System.Drawing.Size(221, 52);
            this.listBookBtn.TabIndex = 1;
            this.listBookBtn.Text = "Kitapları Listele";
            this.listBookBtn.UseVisualStyleBackColor = true;
            this.listBookBtn.Click += new System.EventHandler(this.listBookBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(356, 315);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(174, 52);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Çıkış";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.listBookBtn);
            this.Controls.Add(this.dgwBooks);
            this.Name = "BookListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwBooks;
        private Button listBookBtn;
        private Button exitBtn;
    }
}