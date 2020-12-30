namespace Database_Project
{
    partial class Form_Sections
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
            this.dgv_sections = new System.Windows.Forms.DataGridView();
            this.btn_add_section = new System.Windows.Forms.Button();
            this.btn_delete_section = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sections)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sections
            // 
            this.dgv_sections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sections.Location = new System.Drawing.Point(12, 12);
            this.dgv_sections.Name = "dgv_sections";
            this.dgv_sections.RowHeadersWidth = 51;
            this.dgv_sections.RowTemplate.Height = 24;
            this.dgv_sections.Size = new System.Drawing.Size(540, 332);
            this.dgv_sections.TabIndex = 0;
            // 
            // btn_add_section
            // 
            this.btn_add_section.Location = new System.Drawing.Point(41, 359);
            this.btn_add_section.Name = "btn_add_section";
            this.btn_add_section.Size = new System.Drawing.Size(220, 79);
            this.btn_add_section.TabIndex = 1;
            this.btn_add_section.Text = "Bolum Ekle";
            this.btn_add_section.UseVisualStyleBackColor = true;
            this.btn_add_section.Click += new System.EventHandler(this.btn_add_section_Click);
            // 
            // btn_delete_section
            // 
            this.btn_delete_section.Location = new System.Drawing.Point(287, 359);
            this.btn_delete_section.Name = "btn_delete_section";
            this.btn_delete_section.Size = new System.Drawing.Size(220, 79);
            this.btn_delete_section.TabIndex = 2;
            this.btn_delete_section.Text = "Bolum sil";
            this.btn_delete_section.UseVisualStyleBackColor = true;
            this.btn_delete_section.Click += new System.EventHandler(this.btn_delete_section_Click);
            // 
            // Form_Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btn_delete_section);
            this.Controls.Add(this.btn_add_section);
            this.Controls.Add(this.dgv_sections);
            this.Name = "Form_Sections";
            this.Text = "Form_Sections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Sections_FormClosing);
            this.Load += new System.EventHandler(this.Form_Sections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sections;
        private System.Windows.Forms.Button btn_add_section;
        private System.Windows.Forms.Button btn_delete_section;
    }
}