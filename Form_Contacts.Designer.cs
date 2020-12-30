namespace Database_Project
{
    partial class Form_Contacts
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
            this.dgv_contacts = new System.Windows.Forms.DataGridView();
            this.btn_delete_contact = new System.Windows.Forms.Button();
            this.btn_update_contact = new System.Windows.Forms.Button();
            this.btn_add_contact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contacts
            // 
            this.dgv_contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contacts.Location = new System.Drawing.Point(12, 13);
            this.dgv_contacts.Name = "dgv_contacts";
            this.dgv_contacts.RowHeadersWidth = 51;
            this.dgv_contacts.RowTemplate.Height = 24;
            this.dgv_contacts.Size = new System.Drawing.Size(565, 334);
            this.dgv_contacts.TabIndex = 0;
            this.dgv_contacts.DoubleClick += new System.EventHandler(this.dgv_contacts_DoubleClick);
            // 
            // btn_delete_contact
            // 
            this.btn_delete_contact.Location = new System.Drawing.Point(225, 380);
            this.btn_delete_contact.Name = "btn_delete_contact";
            this.btn_delete_contact.Size = new System.Drawing.Size(138, 35);
            this.btn_delete_contact.TabIndex = 11;
            this.btn_delete_contact.Text = "Iletisim Bilgisi Sil";
            this.btn_delete_contact.UseVisualStyleBackColor = true;
            this.btn_delete_contact.Click += new System.EventHandler(this.btn_delete_contact_Click);
            // 
            // btn_update_contact
            // 
            this.btn_update_contact.Location = new System.Drawing.Point(438, 380);
            this.btn_update_contact.Name = "btn_update_contact";
            this.btn_update_contact.Size = new System.Drawing.Size(138, 35);
            this.btn_update_contact.TabIndex = 10;
            this.btn_update_contact.Text = "Duzenle";
            this.btn_update_contact.UseVisualStyleBackColor = true;
            this.btn_update_contact.Click += new System.EventHandler(this.btn_update_contact_Click);
            // 
            // btn_add_contact
            // 
            this.btn_add_contact.Location = new System.Drawing.Point(12, 380);
            this.btn_add_contact.Name = "btn_add_contact";
            this.btn_add_contact.Size = new System.Drawing.Size(138, 35);
            this.btn_add_contact.TabIndex = 9;
            this.btn_add_contact.Text = "Iletisim Bilgisi Ekle";
            this.btn_add_contact.UseVisualStyleBackColor = true;
            this.btn_add_contact.Click += new System.EventHandler(this.btn_add_contact_Click);
            // 
            // Form_Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 446);
            this.Controls.Add(this.btn_delete_contact);
            this.Controls.Add(this.btn_update_contact);
            this.Controls.Add(this.btn_add_contact);
            this.Controls.Add(this.dgv_contacts);
            this.Name = "Form_Contacts";
            this.Text = "Form_Contacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Contacts_FormClosed);
            this.Load += new System.EventHandler(this.Form_Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contacts;
        private System.Windows.Forms.Button btn_delete_contact;
        private System.Windows.Forms.Button btn_update_contact;
        private System.Windows.Forms.Button btn_add_contact;
    }
}