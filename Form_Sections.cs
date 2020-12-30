using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database_Project
{
    public partial class Form_Sections : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        private string selectStr = @"select * from section_select()";
        //private NpgsqlCommand cmd;
        public Form_Sections()
        { 
            InitializeComponent();
        }

        private void Form_Sections_Load(object sender, EventArgs e)
        {
            connection.Open();
            FunctionsClass.SelectData(selectStr, dgv_sections, connection);
        }

        private void btn_add_section_Click(object sender, EventArgs e)
        {
            try
            {
                sql = @"select * from section_insert(:_name)";
                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_name", dgv_sections.CurrentCell.Value.ToString());
                cmd.ExecuteNonQuery();
                FunctionsClass.SelectData(selectStr, dgv_sections, connection);
            }
            catch (Exception ex){MessageBox.Show("Hata: " + ex);}
        }

        private void btn_delete_section_Click(object sender, EventArgs e)
        {
            sql = @"select * from section_delete(:_id)";
            using var cmd = new NpgsqlCommand(sql, connection);
            //var rowIndex = dgv_sections.CurrentCell.RowIndex;
            cmd.Parameters.AddWithValue("_id", Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_sections, "id")));
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectStr, dgv_sections, connection);
            ////cmd = new NpgsqlCommand(selectStr, conn);
            ////FunctionsClass.SelectData(selectStr,dgv_sections, conn, cmd);
        }

        private void Form_Sections_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}