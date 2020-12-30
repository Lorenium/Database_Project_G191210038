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
    public partial class Form_Contacts : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string selectStr, belongs;
        public int selectedContactId { get; set; }
        //object contact_id;
        public Form_Contacts(string ofClass)
        {
            belongs = ofClass;
            selectStr = FunctionsClass.SelectContactStr(belongs);
            InitializeComponent();
        }

        private void btn_add_contact_Click(object sender, EventArgs e)
        {
            sql = @"select * from contact_insert(:_address, :_email, :_phone)";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("_address", FunctionsClass.GetColumnStr(dgv_contacts, "address"));
            cmd.Parameters.AddWithValue("_email", FunctionsClass.GetColumnStr(dgv_contacts, "e-mail"));
            cmd.Parameters.AddWithValue("_phone", FunctionsClass.GetColumnStr(dgv_contacts, "phone_number"));
            selectedContactId = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            MessageBox.Show ($"Iletisim olusturuldu, {selectedContactId} id'sini kullaniniz!");
            this.Close();
            //FunctionsClass.SelectData(selectStr, dgv_contacts, connection);
        }

        private void btn_delete_contact_Click(object sender, EventArgs e)
        {
            sql = @"select * from contact_delete(:_id)";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("_id", Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_contacts, "contact_id")));
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(sql, dgv_contacts, connection);
        }

        private void btn_update_contact_Click(object sender, EventArgs e)
        {

        }

        private void Form_Contacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void dgv_contacts_DoubleClick(object sender, EventArgs e)
        {
            selectedContactId = Convert.ToInt32(dgv_contacts.Rows[FunctionsClass.GetCurrentRowIndex(dgv_contacts)].Cells["contact_id"].Value.ToString());
            this.Close();
        }

        private void Form_Contacts_Load(object sender, EventArgs e)
        {
            // select only contacts that belong to the owner.
            connection.Open();
            FunctionsClass.SelectData(selectStr, dgv_contacts, connection);
        }
    }
}