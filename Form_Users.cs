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
    public partial class Form_Users : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string selectMem = @"select * from ""Member"" WHERE ""Member"".""member_type"" = 'regular'";
        string selectAc = @"SELECT * FROM ONLY ""Member"" NATURAL FULL JOIN  ""Academician"" WHERE ""Member"".""member_id"" = ""Academician"".""member_id"" ";
        string selectGov = @"SELECT * FROM ONLY ""Member"" NATURAL FULL JOIN  ""Government_Official""  WHERE ""Member"".""member_id"" = ""Government_Official"".""member_id"" ";
        //string selectmem = @"select * from ""Member""";
        //string selectmem = @"select * from ""Member""";

        private void RefreshTables()
        {
            FunctionsClass.SelectData(selectMem, dgv_members, connection);
            FunctionsClass.SelectData(selectAc, dgv_academicians, connection);
            FunctionsClass.SelectData(selectGov, dgv_gov, connection);
        }

        public Form_Users()
        {
            InitializeComponent();
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            connection.Open();
            RefreshTables();
        }

        private void btn_add_member_Click(object sender, EventArgs e)
        {
            Form_Add_Member form_add_member = new Form_Add_Member();
            form_add_member.ShowDialog();
            RefreshTables();
        }

        private void btn_add_auth_Click(object sender, EventArgs e)
        {
            Form_Auth form_auth = new Form_Auth();
            form_auth.ShowDialog();

        }

        private void btn_delete_member_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Member\" where member_id = {FunctionsClass.GetColumnStr(dgv_members, "member_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            //var rowIndex = dgv_authors.CurrentCell.RowIndex;
            //cmd.Parameters.AddWithValue("_id", Convert.ToInt32());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            cmd.ExecuteNonQuery();
            RefreshTables();
        }

        private void btn_add_access_Click(object sender, EventArgs e)
        {
            Form_Access form_access = new Form_Access();
            form_access.ShowDialog();
        }
    }
}
