namespace Database_Project
{
    partial class Form_Digital
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
            this.lbl_documentary = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.dgv_documentary = new System.Windows.Forms.DataGridView();
            this.dgv_course = new System.Windows.Forms.DataGridView();
            this.btn_add_documentary = new System.Windows.Forms.Button();
            this.btn_delete_documentary = new System.Windows.Forms.Button();
            this.btn_add_course = new System.Windows.Forms.Button();
            this.btn_delete_course = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documentary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_documentary
            // 
            this.lbl_documentary.AutoSize = true;
            this.lbl_documentary.Location = new System.Drawing.Point(259, 9);
            this.lbl_documentary.Name = "lbl_documentary";
            this.lbl_documentary.Size = new System.Drawing.Size(78, 17);
            this.lbl_documentary.TabIndex = 0;
            this.lbl_documentary.Text = "Belgeseller";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(847, 9);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(96, 17);
            this.lbl_course.TabIndex = 1;
            this.lbl_course.Text = "Kurs Videolari";
            // 
            // dgv_documentary
            // 
            this.dgv_documentary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_documentary.Location = new System.Drawing.Point(46, 29);
            this.dgv_documentary.Name = "dgv_documentary";
            this.dgv_documentary.RowHeadersWidth = 51;
            this.dgv_documentary.RowTemplate.Height = 24;
            this.dgv_documentary.Size = new System.Drawing.Size(509, 311);
            this.dgv_documentary.TabIndex = 2;
            // 
            // dgv_course
            // 
            this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_course.Location = new System.Drawing.Point(635, 29);
            this.dgv_course.Name = "dgv_course";
            this.dgv_course.RowHeadersWidth = 51;
            this.dgv_course.RowTemplate.Height = 24;
            this.dgv_course.Size = new System.Drawing.Size(509, 311);
            this.dgv_course.TabIndex = 3;
            // 
            // btn_add_documentary
            // 
            this.btn_add_documentary.Location = new System.Drawing.Point(46, 377);
            this.btn_add_documentary.Name = "btn_add_documentary";
            this.btn_add_documentary.Size = new System.Drawing.Size(197, 59);
            this.btn_add_documentary.TabIndex = 4;
            this.btn_add_documentary.Text = "Belgesel Ekle";
            this.btn_add_documentary.UseVisualStyleBackColor = true;
            this.btn_add_documentary.Click += new System.EventHandler(this.btn_add_documentary_Click);
            // 
            // btn_delete_documentary
            // 
            this.btn_delete_documentary.Location = new System.Drawing.Point(358, 377);
            this.btn_delete_documentary.Name = "btn_delete_documentary";
            this.btn_delete_documentary.Size = new System.Drawing.Size(197, 59);
            this.btn_delete_documentary.TabIndex = 5;
            this.btn_delete_documentary.Text = "Belgeseli Sil";
            this.btn_delete_documentary.UseVisualStyleBackColor = true;
            this.btn_delete_documentary.Click += new System.EventHandler(this.btn_delete_documentary_Click);
            // 
            // btn_add_course
            // 
            this.btn_add_course.Location = new System.Drawing.Point(635, 377);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.Size = new System.Drawing.Size(197, 59);
            this.btn_add_course.TabIndex = 6;
            this.btn_add_course.Text = "Kurs Ekle";
            this.btn_add_course.UseVisualStyleBackColor = true;
            this.btn_add_course.Click += new System.EventHandler(this.btn_add_course_Click);
            // 
            // btn_delete_course
            // 
            this.btn_delete_course.Location = new System.Drawing.Point(947, 377);
            this.btn_delete_course.Name = "btn_delete_course";
            this.btn_delete_course.Size = new System.Drawing.Size(197, 59);
            this.btn_delete_course.TabIndex = 7;
            this.btn_delete_course.Text = "Kursu Sil";
            this.btn_delete_course.UseVisualStyleBackColor = true;
            this.btn_delete_course.Click += new System.EventHandler(this.btn_delete_course_Click);
            // 
            // Form_Digital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 448);
            this.Controls.Add(this.btn_delete_course);
            this.Controls.Add(this.btn_add_course);
            this.Controls.Add(this.btn_delete_documentary);
            this.Controls.Add(this.btn_add_documentary);
            this.Controls.Add(this.dgv_course);
            this.Controls.Add(this.dgv_documentary);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_documentary);
            this.Name = "Form_Digital";
            this.Text = "Form_Digital";
            this.Load += new System.EventHandler(this.Form_Digital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documentary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_documentary;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.DataGridView dgv_documentary;
        private System.Windows.Forms.DataGridView dgv_course;
        private System.Windows.Forms.Button btn_add_documentary;
        private System.Windows.Forms.Button btn_delete_documentary;
        private System.Windows.Forms.Button btn_add_course;
        private System.Windows.Forms.Button btn_delete_course;
    }
}