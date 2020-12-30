namespace Database_Project
{
    partial class Form_Add_Member
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
            this.textbox_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_instutition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_department = new System.Windows.Forms.TextBox();
            this.lbl_contact_id = new System.Windows.Forms.Label();
            this.textbox_contact = new System.Windows.Forms.TextBox();
            this.checkbox_regular = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkbox_academician = new System.Windows.Forms.CheckBox();
            this.checkbox_gov = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_access = new System.Windows.Forms.TextBox();
            this.btn_select_access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_firstName
            // 
            this.textbox_firstName.Location = new System.Drawing.Point(110, 12);
            this.textbox_firstName.Name = "textbox_firstName";
            this.textbox_firstName.Size = new System.Drawing.Size(155, 22);
            this.textbox_firstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisim";
            // 
            // textbox_lastName
            // 
            this.textbox_lastName.Location = new System.Drawing.Point(110, 71);
            this.textbox_lastName.Name = "textbox_lastName";
            this.textbox_lastName.Size = new System.Drawing.Size(155, 22);
            this.textbox_lastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kurum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textbox_instutition
            // 
            this.textbox_instutition.Location = new System.Drawing.Point(110, 130);
            this.textbox_instutition.Name = "textbox_instutition";
            this.textbox_instutition.Size = new System.Drawing.Size(155, 22);
            this.textbox_instutition.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Devlet Dairesi";
            // 
            // textbox_department
            // 
            this.textbox_department.Location = new System.Drawing.Point(110, 189);
            this.textbox_department.Name = "textbox_department";
            this.textbox_department.Size = new System.Drawing.Size(155, 22);
            this.textbox_department.TabIndex = 6;
            this.textbox_department.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_contact_id
            // 
            this.lbl_contact_id.AutoSize = true;
            this.lbl_contact_id.Location = new System.Drawing.Point(11, 251);
            this.lbl_contact_id.Name = "lbl_contact_id";
            this.lbl_contact_id.Size = new System.Drawing.Size(90, 17);
            this.lbl_contact_id.TabIndex = 9;
            this.lbl_contact_id.Text = "Iletisim Bilgisi";
            // 
            // textbox_contact
            // 
            this.textbox_contact.Location = new System.Drawing.Point(110, 248);
            this.textbox_contact.Name = "textbox_contact";
            this.textbox_contact.Size = new System.Drawing.Size(155, 22);
            this.textbox_contact.TabIndex = 8;
            // 
            // checkbox_regular
            // 
            this.checkbox_regular.AutoSize = true;
            this.checkbox_regular.Location = new System.Drawing.Point(7, 398);
            this.checkbox_regular.Name = "checkbox_regular";
            this.checkbox_regular.Size = new System.Drawing.Size(79, 21);
            this.checkbox_regular.TabIndex = 12;
            this.checkbox_regular.Text = "Siradan";
            this.checkbox_regular.UseVisualStyleBackColor = true;
            this.checkbox_regular.CheckedChanged += new System.EventHandler(this.checkbox_regular_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Uye Tipi";
            // 
            // checkbox_academician
            // 
            this.checkbox_academician.AutoSize = true;
            this.checkbox_academician.Location = new System.Drawing.Point(101, 398);
            this.checkbox_academician.Name = "checkbox_academician";
            this.checkbox_academician.Size = new System.Drawing.Size(114, 21);
            this.checkbox_academician.TabIndex = 14;
            this.checkbox_academician.Text = "Akademisyen";
            this.checkbox_academician.UseVisualStyleBackColor = true;
            this.checkbox_academician.CheckedChanged += new System.EventHandler(this.checkbox_academician_CheckedChanged);
            // 
            // checkbox_gov
            // 
            this.checkbox_gov.AutoSize = true;
            this.checkbox_gov.Location = new System.Drawing.Point(222, 398);
            this.checkbox_gov.Name = "checkbox_gov";
            this.checkbox_gov.Size = new System.Drawing.Size(129, 21);
            this.checkbox_gov.TabIndex = 15;
            this.checkbox_gov.Text = "Devlet Gorevlisi";
            this.checkbox_gov.UseVisualStyleBackColor = true;
            this.checkbox_gov.CheckedChanged += new System.EventHandler(this.checkbox_gov_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(61, 451);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(227, 34);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Erisim";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textbox_access
            // 
            this.textbox_access.Location = new System.Drawing.Point(110, 307);
            this.textbox_access.Name = "textbox_access";
            this.textbox_access.Size = new System.Drawing.Size(155, 22);
            this.textbox_access.TabIndex = 18;
            // 
            // btn_select_access
            // 
            this.btn_select_access.Location = new System.Drawing.Point(271, 300);
            this.btn_select_access.Name = "btn_select_access";
            this.btn_select_access.Size = new System.Drawing.Size(56, 37);
            this.btn_select_access.TabIndex = 20;
            this.btn_select_access.Text = "Sec";
            this.btn_select_access.UseVisualStyleBackColor = true;
            this.btn_select_access.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Add_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 497);
            this.Controls.Add(this.btn_select_access);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_access);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.checkbox_gov);
            this.Controls.Add(this.checkbox_academician);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkbox_regular);
            this.Controls.Add(this.lbl_contact_id);
            this.Controls.Add(this.textbox_contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_instutition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_firstName);
            this.Name = "Form_Add_Member";
            this.Text = "Form_Add_Member";
            this.Load += new System.EventHandler(this.Form_Add_Member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_instutition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_department;
        private System.Windows.Forms.Label lbl_contact_id;
        private System.Windows.Forms.TextBox textbox_contact;
        private System.Windows.Forms.CheckBox checkbox_regular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkbox_academician;
        private System.Windows.Forms.CheckBox checkbox_gov;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_access;
        private System.Windows.Forms.Button btn_select_access;
    }
}