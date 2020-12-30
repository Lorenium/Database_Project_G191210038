namespace Database_Project
{
    partial class Form_Book
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
            this.lbl_books = new System.Windows.Forms.Label();
            this.lbl_authors = new System.Windows.Forms.Label();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.dgv_authors = new System.Windows.Forms.DataGridView();
            this.dgv_publishers = new System.Windows.Forms.DataGridView();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_update_book = new System.Windows.Forms.Button();
            this.btn_delete_book = new System.Windows.Forms.Button();
            this.btn_delete_author = new System.Windows.Forms.Button();
            this.btn_update_author = new System.Windows.Forms.Button();
            this.btn_add_author = new System.Windows.Forms.Button();
            this.btn_delete_publisher = new System.Windows.Forms.Button();
            this.btn_contact_publisher = new System.Windows.Forms.Button();
            this.btn_add_publisher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publishers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_books
            // 
            this.lbl_books.AutoSize = true;
            this.lbl_books.Location = new System.Drawing.Point(138, 42);
            this.lbl_books.Name = "lbl_books";
            this.lbl_books.Size = new System.Drawing.Size(56, 17);
            this.lbl_books.TabIndex = 0;
            this.lbl_books.Text = "Kitaplar";
            // 
            // lbl_authors
            // 
            this.lbl_authors.AutoSize = true;
            this.lbl_authors.Location = new System.Drawing.Point(435, 42);
            this.lbl_authors.Name = "lbl_authors";
            this.lbl_authors.Size = new System.Drawing.Size(61, 17);
            this.lbl_authors.TabIndex = 1;
            this.lbl_authors.Text = "Yazarlar";
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Location = new System.Drawing.Point(729, 42);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(77, 17);
            this.lbl_publisher.TabIndex = 2;
            this.lbl_publisher.Text = "Yayinevleri";
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(48, 81);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.Size = new System.Drawing.Size(246, 232);
            this.dgv_books.TabIndex = 3;
            // 
            // dgv_authors
            // 
            this.dgv_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_authors.Location = new System.Drawing.Point(344, 81);
            this.dgv_authors.Name = "dgv_authors";
            this.dgv_authors.RowHeadersWidth = 51;
            this.dgv_authors.RowTemplate.Height = 24;
            this.dgv_authors.Size = new System.Drawing.Size(246, 232);
            this.dgv_authors.TabIndex = 4;
            // 
            // dgv_publishers
            // 
            this.dgv_publishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_publishers.Location = new System.Drawing.Point(640, 81);
            this.dgv_publishers.Name = "dgv_publishers";
            this.dgv_publishers.RowHeadersWidth = 51;
            this.dgv_publishers.RowTemplate.Height = 24;
            this.dgv_publishers.Size = new System.Drawing.Size(246, 232);
            this.dgv_publishers.TabIndex = 5;
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(48, 339);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(246, 35);
            this.btn_add_book.TabIndex = 6;
            this.btn_add_book.Text = "Kitap Ekle";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_update_book
            // 
            this.btn_update_book.Location = new System.Drawing.Point(48, 463);
            this.btn_update_book.Name = "btn_update_book";
            this.btn_update_book.Size = new System.Drawing.Size(246, 35);
            this.btn_update_book.TabIndex = 7;
            this.btn_update_book.Text = "Kitabi Degistir";
            this.btn_update_book.UseVisualStyleBackColor = true;
            this.btn_update_book.Click += new System.EventHandler(this.btn_update_book_Click);
            // 
            // btn_delete_book
            // 
            this.btn_delete_book.Location = new System.Drawing.Point(48, 401);
            this.btn_delete_book.Name = "btn_delete_book";
            this.btn_delete_book.Size = new System.Drawing.Size(246, 35);
            this.btn_delete_book.TabIndex = 8;
            this.btn_delete_book.Text = "Kitabi Sil";
            this.btn_delete_book.UseVisualStyleBackColor = true;
            this.btn_delete_book.Click += new System.EventHandler(this.btn_delete_book_Click);
            // 
            // btn_delete_author
            // 
            this.btn_delete_author.Location = new System.Drawing.Point(344, 401);
            this.btn_delete_author.Name = "btn_delete_author";
            this.btn_delete_author.Size = new System.Drawing.Size(246, 35);
            this.btn_delete_author.TabIndex = 11;
            this.btn_delete_author.Text = "Yazari Sil";
            this.btn_delete_author.UseVisualStyleBackColor = true;
            this.btn_delete_author.Click += new System.EventHandler(this.btn_delete_author_Click);
            // 
            // btn_update_author
            // 
            this.btn_update_author.Location = new System.Drawing.Point(344, 463);
            this.btn_update_author.Name = "btn_update_author";
            this.btn_update_author.Size = new System.Drawing.Size(246, 35);
            this.btn_update_author.TabIndex = 10;
            this.btn_update_author.Text = "Yazari Degistir";
            this.btn_update_author.UseVisualStyleBackColor = true;
            this.btn_update_author.Click += new System.EventHandler(this.btn_update_author_Click);
            // 
            // btn_add_author
            // 
            this.btn_add_author.Location = new System.Drawing.Point(344, 339);
            this.btn_add_author.Name = "btn_add_author";
            this.btn_add_author.Size = new System.Drawing.Size(246, 35);
            this.btn_add_author.TabIndex = 9;
            this.btn_add_author.Text = "Yazar Ekle";
            this.btn_add_author.UseVisualStyleBackColor = true;
            this.btn_add_author.Click += new System.EventHandler(this.btn_add_author_Click);
            // 
            // btn_delete_publisher
            // 
            this.btn_delete_publisher.Location = new System.Drawing.Point(640, 401);
            this.btn_delete_publisher.Name = "btn_delete_publisher";
            this.btn_delete_publisher.Size = new System.Drawing.Size(246, 35);
            this.btn_delete_publisher.TabIndex = 14;
            this.btn_delete_publisher.Text = "Yayinevini Sil";
            this.btn_delete_publisher.UseVisualStyleBackColor = true;
            this.btn_delete_publisher.Click += new System.EventHandler(this.btn_delete_publisher_Click);
            // 
            // btn_contact_publisher
            // 
            this.btn_contact_publisher.Location = new System.Drawing.Point(640, 463);
            this.btn_contact_publisher.Name = "btn_contact_publisher";
            this.btn_contact_publisher.Size = new System.Drawing.Size(246, 35);
            this.btn_contact_publisher.TabIndex = 13;
            this.btn_contact_publisher.Text = "Yayinevleri Iletisim";
            this.btn_contact_publisher.UseVisualStyleBackColor = true;
            this.btn_contact_publisher.Click += new System.EventHandler(this.btn_contact_publisher_Click);
            // 
            // btn_add_publisher
            // 
            this.btn_add_publisher.Location = new System.Drawing.Point(640, 339);
            this.btn_add_publisher.Name = "btn_add_publisher";
            this.btn_add_publisher.Size = new System.Drawing.Size(246, 35);
            this.btn_add_publisher.TabIndex = 12;
            this.btn_add_publisher.Text = "Yayinevi Ekle";
            this.btn_add_publisher.UseVisualStyleBackColor = true;
            this.btn_add_publisher.Click += new System.EventHandler(this.btn_add_publisher_Click);
            // 
            // Form_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 528);
            this.Controls.Add(this.btn_delete_publisher);
            this.Controls.Add(this.btn_contact_publisher);
            this.Controls.Add(this.btn_add_publisher);
            this.Controls.Add(this.btn_delete_author);
            this.Controls.Add(this.btn_update_author);
            this.Controls.Add(this.btn_add_author);
            this.Controls.Add(this.btn_delete_book);
            this.Controls.Add(this.btn_update_book);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.dgv_publishers);
            this.Controls.Add(this.dgv_authors);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.lbl_publisher);
            this.Controls.Add(this.lbl_authors);
            this.Controls.Add(this.lbl_books);
            this.Name = "Form_Book";
            this.Text = "Form_Book";
            this.Load += new System.EventHandler(this.Form_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_authors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_books;
        private System.Windows.Forms.Label lbl_authors;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.DataGridView dgv_authors;
        private System.Windows.Forms.DataGridView dgv_publishers;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_update_book;
        private System.Windows.Forms.Button btn_delete_book;
        private System.Windows.Forms.Button btn_delete_author;
        private System.Windows.Forms.Button btn_update_author;
        private System.Windows.Forms.Button btn_add_author;
        private System.Windows.Forms.Button btn_delete_publisher;
        private System.Windows.Forms.Button btn_contact_publisher;
        private System.Windows.Forms.Button btn_add_publisher;
    }
}