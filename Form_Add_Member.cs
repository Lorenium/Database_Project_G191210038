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
    public partial class Form_Add_Member : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;

        public Form_Add_Member()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Add_Member_Load(object sender, EventArgs e)
        {
            connection.Open();
            textbox_instutition.Enabled = false;
            textbox_department.Enabled = false;
            textbox_access.Enabled = false;
            checkbox_regular.Checked = true;
            //if (!checkbox_academician.Checked)
            //    textbox_instutition.Enabled = false;
            //if (!checkbox_gov.Checked)
            //    textbox_department.Enabled = false;
        }

        private void checkbox_academician_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_academician.Checked)
                textbox_instutition.Enabled = false;
            else
            {
                textbox_instutition.Enabled = true;
                textbox_access.Enabled = true;
                checkbox_gov.Checked = false;
                checkbox_regular.Checked = false;
            }
        }

        private void checkbox_gov_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_gov.Checked)
                textbox_department.Enabled = false;
            else
            {
                textbox_department.Enabled = true;
                textbox_access.Enabled = true;
                checkbox_academician.Checked = false;
                checkbox_regular.Checked = false;
            }

        }

        private void checkbox_regular_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_regular.Checked)
            {
                checkbox_academician.Checked = false;
                checkbox_gov.Checked = false;
                textbox_access.Enabled = false;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string[] values = new string[]
            {
                textbox_contact.Text,
                textbox_firstName.Text,
                textbox_lastName.Text
            };
            if (checkbox_regular.Checked)
                sql = $"insert into \"Member\"(contact_id, first_name, last_name, member_type) values({Convert.ToInt32(values[0])}, '{values[1]}', '{values[2]}', 'regular')";
            else if (checkbox_academician.Checked)
            {
                string instutition = textbox_instutition.Text;
                int access_id = Convert.ToInt32(textbox_access.Text);
                sql = $"select * from academician_add_new({Convert.ToInt32(values[0])}, '{values[1]}', '{values[2]}', {access_id}, '{instutition}')";
            }
            else
            {
                string department = textbox_department.Text;
                int access_id = Convert.ToInt32(textbox_access.Text);
                sql = $"select * from gov_add_new({Convert.ToInt32(values[0])}, '{values[1]}', '{values[2]}', {access_id}, '{department}')";
            }

            try
            {
                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Contacts form_contacts = new Form_Contacts("Member");
            form_contacts.ShowDialog();
            textbox_contact.Text = form_contacts.selectedContactId.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Access form_access = new Form_Access();
            form_access.ShowDialog();
            textbox_access.Text = form_access.current_access_id.ToString();
        }
    }
}
