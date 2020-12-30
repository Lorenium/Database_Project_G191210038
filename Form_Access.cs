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
    public partial class Form_Access : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string selectStr = @"select * from ""Exclusive_Access""";

        public int current_access_id { get; set; }

        public Form_Access()
        {
            InitializeComponent();
        }

        private void Form_Access_Load(object sender, EventArgs e)
        {
            connection.Open();
            FunctionsClass.SelectData(selectStr, dgv_access, connection);
        }

        private void dgv_access_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_access_Click(object sender, EventArgs e)
        {
            var login_id = FunctionsClass.GetColumnStr(dgv_access, "login_id");
            var book_id = FunctionsClass.GetColumnStr(dgv_access, "book_id");
            sql = $"insert into \"Exclusive_Access\" (login_id, book_id) values ({login_id}, {book_id})";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectStr, dgv_access, connection);
        }

        private void btn_delete_access_Click(object sender, EventArgs e)
        {
            sql = sql = $"delete from \"Exclusive_Access\" where access_id = {FunctionsClass.GetColumnStr(dgv_access, "access_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectStr, dgv_access, connection);
        }

        private void dgv_access_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            current_access_id = Convert.ToInt32(dgv_access.Rows[e.RowIndex].Cells["access_id"].Value.ToString());
            this.Close();
        }
    }
}
