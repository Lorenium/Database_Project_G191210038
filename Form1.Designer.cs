namespace Database_Project
{
    partial class Form_MainMenu
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
            this.btn_sections = new System.Windows.Forms.Button();
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_digital = new System.Windows.Forms.Button();
            this.btn_members = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sections
            // 
            this.btn_sections.Location = new System.Drawing.Point(70, 508);
            this.btn_sections.Name = "btn_sections";
            this.btn_sections.Size = new System.Drawing.Size(262, 79);
            this.btn_sections.TabIndex = 1;
            this.btn_sections.Text = "Kutuphane Bolumleri";
            this.btn_sections.UseVisualStyleBackColor = true;
            this.btn_sections.Click += new System.EventHandler(this.btn_sections_Click);
            // 
            // btn_books
            // 
            this.btn_books.Location = new System.Drawing.Point(408, 508);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(262, 79);
            this.btn_books.TabIndex = 2;
            this.btn_books.Text = "Kitaplar";
            this.btn_books.UseVisualStyleBackColor = true;
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_digital
            // 
            this.btn_digital.Location = new System.Drawing.Point(746, 508);
            this.btn_digital.Name = "btn_digital";
            this.btn_digital.Size = new System.Drawing.Size(262, 79);
            this.btn_digital.TabIndex = 3;
            this.btn_digital.Text = "Dijital Materyaller";
            this.btn_digital.UseVisualStyleBackColor = true;
            this.btn_digital.Click += new System.EventHandler(this.btn_digital_Click);
            // 
            // btn_members
            // 
            this.btn_members.Location = new System.Drawing.Point(853, 48);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(262, 79);
            this.btn_members.TabIndex = 4;
            this.btn_members.Text = "Uyeler / Kullanicilar";
            this.btn_members.UseVisualStyleBackColor = true;
            this.btn_members.Click += new System.EventHandler(this.btn_members_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(853, 350);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(262, 79);
            this.btn_borrow.TabIndex = 5;
            this.btn_borrow.Text = "Odunc Kitap Al";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.Location = new System.Drawing.Point(853, 199);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(262, 79);
            this.btn_staff.TabIndex = 6;
            this.btn_staff.Text = "Personel";
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Database_Project.Properties.Resources._940x788_px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_staff);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_members);
            this.Controls.Add(this.btn_digital);
            this.Controls.Add(this.btn_books);
            this.Controls.Add(this.btn_sections);
            this.Name = "Form_MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sections;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_digital;
        private System.Windows.Forms.Button btn_members;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

