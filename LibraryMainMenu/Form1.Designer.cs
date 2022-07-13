namespace LibraryMainMenu
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.bookListBtn = new System.Windows.Forms.Button();
            this.getMemberListBtn = new System.Windows.Forms.Button();
            this.MemberThingsBtn = new System.Windows.Forms.Button();
            this.lendABookBtn = new System.Windows.Forms.Button();
            this.BookThingsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.takeBackBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListBtn
            // 
            this.bookListBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bookListBtn.Location = new System.Drawing.Point(751, 52);
            this.bookListBtn.Name = "bookListBtn";
            this.bookListBtn.Size = new System.Drawing.Size(340, 56);
            this.bookListBtn.TabIndex = 0;
            this.bookListBtn.Text = "Kitap Listesi";
            this.bookListBtn.UseVisualStyleBackColor = false;
            this.bookListBtn.Click += new System.EventHandler(this.bookListBtn_Click);
            // 
            // getMemberListBtn
            // 
            this.getMemberListBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.getMemberListBtn.Location = new System.Drawing.Point(27, 52);
            this.getMemberListBtn.Name = "getMemberListBtn";
            this.getMemberListBtn.Size = new System.Drawing.Size(326, 56);
            this.getMemberListBtn.TabIndex = 1;
            this.getMemberListBtn.Text = "Üye Listesi";
            this.getMemberListBtn.UseVisualStyleBackColor = false;
            this.getMemberListBtn.Click += new System.EventHandler(this.getMemberListBtn_Click);
            // 
            // MemberThingsBtn
            // 
            this.MemberThingsBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.MemberThingsBtn.Location = new System.Drawing.Point(27, 169);
            this.MemberThingsBtn.Name = "MemberThingsBtn";
            this.MemberThingsBtn.Size = new System.Drawing.Size(326, 54);
            this.MemberThingsBtn.TabIndex = 2;
            this.MemberThingsBtn.Text = "Üye Ekle/Sil/Güncelle";
            this.MemberThingsBtn.UseVisualStyleBackColor = false;
            this.MemberThingsBtn.Click += new System.EventHandler(this.MemberThingsBtn_Click);
            // 
            // lendABookBtn
            // 
            this.lendABookBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lendABookBtn.Location = new System.Drawing.Point(751, 169);
            this.lendABookBtn.Name = "lendABookBtn";
            this.lendABookBtn.Size = new System.Drawing.Size(340, 54);
            this.lendABookBtn.TabIndex = 4;
            this.lendABookBtn.Text = "Kitap Ödünç Ver";
            this.lendABookBtn.UseVisualStyleBackColor = false;
            this.lendABookBtn.Click += new System.EventHandler(this.lendABookBtn_Click);
            // 
            // BookThingsBtn
            // 
            this.BookThingsBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BookThingsBtn.Location = new System.Drawing.Point(751, 327);
            this.BookThingsBtn.Name = "BookThingsBtn";
            this.BookThingsBtn.Size = new System.Drawing.Size(340, 53);
            this.BookThingsBtn.TabIndex = 5;
            this.BookThingsBtn.Text = "Kitap Ekle/Sil/Güncelle";
            this.BookThingsBtn.UseVisualStyleBackColor = false;
            this.BookThingsBtn.Click += new System.EventHandler(this.BookThingsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Tan;
            this.exitBtn.Location = new System.Drawing.Point(27, 453);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(176, 44);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Çıkış";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // takeBackBookBtn
            // 
            this.takeBackBookBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.takeBackBookBtn.Location = new System.Drawing.Point(751, 245);
            this.takeBackBookBtn.Name = "takeBackBookBtn";
            this.takeBackBookBtn.Size = new System.Drawing.Size(340, 53);
            this.takeBackBookBtn.TabIndex = 7;
            this.takeBackBookBtn.Text = "KITAP TESLİM AL";
            this.takeBackBookBtn.UseVisualStyleBackColor = false;
            this.takeBackBookBtn.Click += new System.EventHandler(this.takeBackBookBtn_Click);
            // 
            // MainMenuForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 548);
            this.Controls.Add(this.takeBackBookBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.BookThingsBtn);
            this.Controls.Add(this.lendABookBtn);
            this.Controls.Add(this.MemberThingsBtn);
            this.Controls.Add(this.getMemberListBtn);
            this.Controls.Add(this.bookListBtn);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Library Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bookListBtn;
        private Button getMemberListBtn;
        private Button MemberThingsBtn;
        private Button lendABookBtn;
        private Button BookThingsBtn;
        private Button exitBtn;
        private Button takeBackBookBtn;
    }
}