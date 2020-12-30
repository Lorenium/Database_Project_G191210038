namespace Database_Project
{
    partial class Form_Access
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
            this.dgv_access = new System.Windows.Forms.DataGridView();
            this.btn_add_access = new System.Windows.Forms.Button();
            this.btn_delete_access = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_access)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_access
            // 
            this.dgv_access.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_access.Location = new System.Drawing.Point(12, 12);
            this.dgv_access.Name = "dgv_access";
            this.dgv_access.RowHeadersWidth = 51;
            this.dgv_access.RowTemplate.Height = 24;
            this.dgv_access.Size = new System.Drawing.Size(333, 293);
            this.dgv_access.TabIndex = 0;
            this.dgv_access.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_access_CellContentDoubleClick);
            this.dgv_access.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_access_CellDoubleClick);
            // 
            // btn_add_access
            // 
            this.btn_add_access.Location = new System.Drawing.Point(13, 327);
            this.btn_add_access.Name = "btn_add_access";
            this.btn_add_access.Size = new System.Drawing.Size(160, 51);
            this.btn_add_access.TabIndex = 1;
            this.btn_add_access.Text = "EKLE";
            this.btn_add_access.UseVisualStyleBackColor = true;
            this.btn_add_access.Click += new System.EventHandler(this.btn_add_access_Click);
            // 
            // btn_delete_access
            // 
            this.btn_delete_access.Location = new System.Drawing.Point(185, 327);
            this.btn_delete_access.Name = "btn_delete_access";
            this.btn_delete_access.Size = new System.Drawing.Size(160, 51);
            this.btn_delete_access.TabIndex = 2;
            this.btn_delete_access.Text = "KALDIR";
            this.btn_delete_access.UseVisualStyleBackColor = true;
            this.btn_delete_access.Click += new System.EventHandler(this.btn_delete_access_Click);
            // 
            // Form_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 390);
            this.Controls.Add(this.btn_delete_access);
            this.Controls.Add(this.btn_add_access);
            this.Controls.Add(this.dgv_access);
            this.Name = "Form_Access";
            this.Text = "Form_Access";
            this.Load += new System.EventHandler(this.Form_Access_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_access)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_access;
        private System.Windows.Forms.Button btn_add_access;
        private System.Windows.Forms.Button btn_delete_access;
    }
}