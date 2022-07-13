namespace MemberListApp
{
    partial class MemberListForm
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
            this.dgwMembers = new System.Windows.Forms.DataGridView();
            this.listMemberBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMembers
            // 
            this.dgwMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMembers.Location = new System.Drawing.Point(12, 12);
            this.dgwMembers.Name = "dgwMembers";
            this.dgwMembers.RowHeadersWidth = 51;
            this.dgwMembers.RowTemplate.Height = 29;
            this.dgwMembers.Size = new System.Drawing.Size(776, 308);
            this.dgwMembers.TabIndex = 0;
            // 
            // listMemberBtn
            // 
            this.listMemberBtn.Location = new System.Drawing.Point(37, 346);
            this.listMemberBtn.Name = "listMemberBtn";
            this.listMemberBtn.Size = new System.Drawing.Size(218, 55);
            this.listMemberBtn.TabIndex = 1;
            this.listMemberBtn.Text = "Üyeleri Listele";
            this.listMemberBtn.UseVisualStyleBackColor = true;
            this.listMemberBtn.Click += new System.EventHandler(this.listMemberBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(332, 346);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(164, 55);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Çıkış";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.listMemberBtn);
            this.Controls.Add(this.dgwMembers);
            this.Name = "MemberListForm";
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.MemberListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwMembers;
        private Button listMemberBtn;
        private Button exitBtn;
    }
}