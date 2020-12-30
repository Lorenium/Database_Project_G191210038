namespace Database_Project
{
    partial class Form_Users
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
            this.dgv_members = new System.Windows.Forms.DataGridView();
            this.dgv_academicians = new System.Windows.Forms.DataGridView();
            this.dgv_gov = new System.Windows.Forms.DataGridView();
            this.lbl_member = new System.Windows.Forms.Label();
            this.lbl_academician = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_member = new System.Windows.Forms.Button();
            this.btn_delete_member = new System.Windows.Forms.Button();
            this.btn_add_auth = new System.Windows.Forms.Button();
            this.btn_add_access = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_members)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_academicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gov)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_members
            // 
            this.dgv_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_members.Location = new System.Drawing.Point(47, 29);
            this.dgv_members.Name = "dgv_members";
            this.dgv_members.RowHeadersWidth = 51;
            this.dgv_members.RowTemplate.Height = 24;
            this.dgv_members.Size = new System.Drawing.Size(424, 339);
            this.dgv_members.TabIndex = 0;
            // 
            // dgv_academicians
            // 
            this.dgv_academicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_academicians.Location = new System.Drawing.Point(577, 29);
            this.dgv_academicians.Name = "dgv_academicians";
            this.dgv_academicians.RowHeadersWidth = 51;
            this.dgv_academicians.RowTemplate.Height = 24;
            this.dgv_academicians.Size = new System.Drawing.Size(240, 150);
            this.dgv_academicians.TabIndex = 1;
            // 
            // dgv_gov
            // 
            this.dgv_gov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gov.Location = new System.Drawing.Point(577, 218);
            this.dgv_gov.Name = "dgv_gov";
            this.dgv_gov.RowHeadersWidth = 51;
            this.dgv_gov.Size = new System.Drawing.Size(240, 150);
            this.dgv_gov.TabIndex = 2;
            // 
            // lbl_member
            // 
            this.lbl_member.AutoSize = true;
            this.lbl_member.Location = new System.Drawing.Point(189, 9);
            this.lbl_member.Name = "lbl_member";
            this.lbl_member.Size = new System.Drawing.Size(121, 17);
            this.lbl_member.TabIndex = 3;
            this.lbl_member.Text = "Uyeler/Kullanicilar";
            // 
            // lbl_academician
            // 
            this.lbl_academician.AutoSize = true;
            this.lbl_academician.Location = new System.Drawing.Point(648, 9);
            this.lbl_academician.Name = "lbl_academician";
            this.lbl_academician.Size = new System.Drawing.Size(108, 17);
            this.lbl_academician.TabIndex = 4;
            this.lbl_academician.Text = "Akademisyenler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Devlet Gorevlileri";
            // 
            // btn_add_member
            // 
            this.btn_add_member.Location = new System.Drawing.Point(883, 29);
            this.btn_add_member.Name = "btn_add_member";
            this.btn_add_member.Size = new System.Drawing.Size(159, 52);
            this.btn_add_member.TabIndex = 6;
            this.btn_add_member.Text = "Uye Ekle";
            this.btn_add_member.UseVisualStyleBackColor = true;
            this.btn_add_member.Click += new System.EventHandler(this.btn_add_member_Click);
            // 
            // btn_delete_member
            // 
            this.btn_delete_member.Location = new System.Drawing.Point(883, 124);
            this.btn_delete_member.Name = "btn_delete_member";
            this.btn_delete_member.Size = new System.Drawing.Size(159, 52);
            this.btn_delete_member.TabIndex = 7;
            this.btn_delete_member.Text = "Uyeyi Sil";
            this.btn_delete_member.UseVisualStyleBackColor = true;
            this.btn_delete_member.Click += new System.EventHandler(this.btn_delete_member_Click);
            // 
            // btn_add_auth
            // 
            this.btn_add_auth.Location = new System.Drawing.Point(883, 219);
            this.btn_add_auth.Name = "btn_add_auth";
            this.btn_add_auth.Size = new System.Drawing.Size(159, 52);
            this.btn_add_auth.TabIndex = 8;
            this.btn_add_auth.Text = "Giris Bilgileri Ekle";
            this.btn_add_auth.UseVisualStyleBackColor = true;
            this.btn_add_auth.Click += new System.EventHandler(this.btn_add_auth_Click);
            // 
            // btn_add_access
            // 
            this.btn_add_access.Location = new System.Drawing.Point(883, 314);
            this.btn_add_access.Name = "btn_add_access";
            this.btn_add_access.Size = new System.Drawing.Size(159, 52);
            this.btn_add_access.TabIndex = 9;
            this.btn_add_access.Text = "Erisim Hakki Ekle";
            this.btn_add_access.UseVisualStyleBackColor = true;
            this.btn_add_access.Click += new System.EventHandler(this.btn_add_access_Click);
            // 
            // Form_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 430);
            this.Controls.Add(this.btn_add_access);
            this.Controls.Add(this.btn_add_auth);
            this.Controls.Add(this.btn_delete_member);
            this.Controls.Add(this.btn_add_member);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_academician);
            this.Controls.Add(this.lbl_member);
            this.Controls.Add(this.dgv_gov);
            this.Controls.Add(this.dgv_academicians);
            this.Controls.Add(this.dgv_members);
            this.Name = "Form_Users";
            this.Text = "Form_Users";
            this.Load += new System.EventHandler(this.Form_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_members)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_academicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_members;
        private System.Windows.Forms.DataGridView dgv_academicians;
        private System.Windows.Forms.DataGridView dgv_gov;
        private System.Windows.Forms.Label lbl_member;
        private System.Windows.Forms.Label lbl_academician;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_member;
        private System.Windows.Forms.Button btn_delete_member;
        private System.Windows.Forms.Button btn_add_auth;
        private System.Windows.Forms.Button btn_add_access;
    }
}