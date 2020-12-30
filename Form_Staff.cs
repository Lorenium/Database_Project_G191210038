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
    public partial class Form_Staff : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string select = @"Select * from ""Staff""";

        public Form_Staff()
        {
            InitializeComponent();
        }

        private void Form_Staff_Load(object sender, EventArgs e)
        {
            connection.Open();
            FunctionsClass.SelectData(select, dgv_staff, connection);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Contacts form_contacts = new Form_Contacts("Staff");
            form_contacts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Auth form_auth = new Form_Auth();
            form_auth.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = new string[] {
                FunctionsClass.GetColumnStr(dgv_staff,"contact_id"),
                FunctionsClass.GetColumnStr(dgv_staff,"section_id"),
                FunctionsClass.GetColumnStr(dgv_staff,"login_id"),
                FunctionsClass.GetColumnStr(dgv_staff,"first_name"),
                FunctionsClass.GetColumnStr(dgv_staff,"last_name"),
                FunctionsClass.GetColumnStr(dgv_staff,"job_description"),
                FunctionsClass.GetColumnStr(dgv_staff,"salary")
            };

            //insert into "Staff"(contact_id, section_id, login_id, first_name, last_name, job_description, salary) values(3, 46, 3, 'ali', 'veli', 'ogretim', 3000)
            sql = $"insert into \"Staff\"(contact_id, section_id, login_id, first_name, last_name, job_description, salary) values({values[0]}, {values[1]}, {values[2]}, '{values[3]}', '{values[4]}', '{values[5]}', {values[6]})";
            using var cmd = new NpgsqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
                FunctionsClass.SelectData(select, dgv_staff, connection);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Staff\" where staff_id = {FunctionsClass.GetColumnStr(dgv_staff, "staff_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            //var rowIndex = dgv_authors.CurrentCell.RowIndex;
            //cmd.Parameters.AddWithValue("_id", Convert.ToInt32());
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(select, dgv_staff, connection);
        }
    }
}
