namespace Database_Project
{
    partial class Form_Borrow
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
            this.dgv_memb = new System.Windows.Forms.DataGridView();
            this.dgv_book = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_copies = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_borrow = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_bookid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_memb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_memb
            // 
            this.dgv_memb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_memb.Location = new System.Drawing.Point(12, 50);
            this.dgv_memb.Name = "dgv_memb";
            this.dgv_memb.RowHeadersWidth = 51;
            this.dgv_memb.RowTemplate.Height = 24;
            this.dgv_memb.Size = new System.Drawing.Size(410, 473);
            this.dgv_memb.TabIndex = 0;
            // 
            // dgv_book
            // 
            this.dgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book.Location = new System.Drawing.Point(464, 50);
            this.dgv_book.Name = "dgv_book";
            this.dgv_book.RowHeadersWidth = 51;
            this.dgv_book.RowTemplate.Height = 24;
            this.dgv_book.Size = new System.Drawing.Size(376, 174);
            this.dgv_book.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanicilar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitaplar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Odunc Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(930, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(930, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kopya ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kullanici ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kopya Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kopyalar";
            // 
            // dgv_copies
            // 
            this.dgv_copies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_copies.Location = new System.Drawing.Point(464, 254);
            this.dgv_copies.Name = "dgv_copies";
            this.dgv_copies.RowHeadersWidth = 51;
            this.dgv_copies.RowTemplate.Height = 24;
            this.dgv_copies.Size = new System.Drawing.Size(376, 174);
            this.dgv_copies.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Odunc Alma islemleri";
            // 
            // dgv_borrow
            // 
            this.dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrow.Location = new System.Drawing.Point(464, 468);
            this.dgv_borrow.Name = "dgv_borrow";
            this.dgv_borrow.RowHeadersWidth = 51;
            this.dgv_borrow.RowTemplate.Height = 24;
            this.dgv_borrow.Size = new System.Drawing.Size(376, 174);
            this.dgv_borrow.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(950, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kitap ID";
            // 
            // textbox_bookid
            // 
            this.textbox_bookid.Location = new System.Drawing.Point(930, 187);
            this.textbox_bookid.Name = "textbox_bookid";
            this.textbox_bookid.Size = new System.Drawing.Size(100, 22);
            this.textbox_bookid.TabIndex = 14;
            // 
            // Form_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 656);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_bookid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_borrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_copies);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_book);
            this.Controls.Add(this.dgv_memb);
            this.Name = "Form_Borrow";
            this.Text = "Form_Borrow";
            this.Load += new System.EventHandler(this.Form_Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_memb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_memb;
        private System.Windows.Forms.DataGridView dgv_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_copies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_borrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_bookid;
    }
}