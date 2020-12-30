namespace Database_Project
{
    partial class Form_Auth
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
            this.dgv_auth = new System.Windows.Forms.DataGridView();
            this.btn_add_auth = new System.Windows.Forms.Button();
            this.btn_delete_auth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auth)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_auth
            // 
            this.dgv_auth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_auth.Location = new System.Drawing.Point(12, 12);
            this.dgv_auth.Name = "dgv_auth";
            this.dgv_auth.RowHeadersWidth = 51;
            this.dgv_auth.RowTemplate.Height = 24;
            this.dgv_auth.Size = new System.Drawing.Size(356, 332);
            this.dgv_auth.TabIndex = 0;
            this.dgv_auth.DoubleClick += new System.EventHandler(this.dgv_auth_DoubleClick);
            // 
            // btn_add_auth
            // 
            this.btn_add_auth.Location = new System.Drawing.Point(12, 380);
            this.btn_add_auth.Name = "btn_add_auth";
            this.btn_add_auth.Size = new System.Drawing.Size(172, 55);
            this.btn_add_auth.TabIndex = 1;
            this.btn_add_auth.Text = "EKLE";
            this.btn_add_auth.UseVisualStyleBackColor = true;
            this.btn_add_auth.Click += new System.EventHandler(this.btn_add_auth_Click);
            // 
            // btn_delete_auth
            // 
            this.btn_delete_auth.Location = new System.Drawing.Point(196, 380);
            this.btn_delete_auth.Name = "btn_delete_auth";
            this.btn_delete_auth.Size = new System.Drawing.Size(172, 55);
            this.btn_delete_auth.TabIndex = 2;
            this.btn_delete_auth.Text = "SIL";
            this.btn_delete_auth.UseVisualStyleBackColor = true;
            this.btn_delete_auth.Click += new System.EventHandler(this.btn_delete_auth_Click);
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 463);
            this.Controls.Add(this.btn_delete_auth);
            this.Controls.Add(this.btn_add_auth);
            this.Controls.Add(this.dgv_auth);
            this.Name = "Form_Auth";
            this.Text = "Form_Auth";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_auth;
        private System.Windows.Forms.Button btn_add_auth;
        private System.Windows.Forms.Button btn_delete_auth;
    }
}