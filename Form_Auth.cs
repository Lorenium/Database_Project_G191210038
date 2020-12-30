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
    public partial class Form_Auth : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string selectStr = @"select * from ""Authentication_Info""";

        public int current_login_id { get; set; }
        public Form_Auth()
        {
            InitializeComponent();
        }

        private void Form_Auth_Load(object sender, EventArgs e)
        {
            connection.Open();
            FunctionsClass.SelectData(selectStr, dgv_auth, connection);
        }

        private void btn_add_auth_Click(object sender, EventArgs e)
        {
            var passwd = FunctionsClass.GetColumnStr(dgv_auth, "password");
            sql = $"insert into \"Authentication_Info\"(password) values('{passwd}')";
            using var cmd = new NpgsqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FunctionsClass.SelectData(selectStr, dgv_auth, connection);
        }

        private void dgv_auth_DoubleClick(object sender, EventArgs e)
        {
            current_login_id = Convert.ToInt32(dgv_auth.Rows[FunctionsClass.GetCurrentRowIndex(dgv_auth)].Cells["login_id"].Value.ToString());
            this.Close();
        }

        private void btn_delete_auth_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Authentication_Info\"  where login_id = {FunctionsClass.GetColumnStr(dgv_auth, "login_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectStr, dgv_auth, connection);
        }
    }
}
