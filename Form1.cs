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
    public partial class Form_MainMenu : Form
    {
        //private NpgsqlConnection conn;
        private readonly string sql = @"select * from section_select()";
        //private NpgsqlCommand cmd;
        //private DataTable dt;

        public Form_MainMenu()
        {
            InitializeComponent();
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            //conn = new NpgsqlConnection(FunctionsClass.connstring);
            //FunctionsClass.SelectData(sql, dgv_MainMenu, conn);
        }
 

        private void btn_sections_Click(object sender, EventArgs e)
        {
            Form_Sections form_sections = new Form_Sections();
            form_sections.Show();
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            Form_Book form_book = new Form_Book();
            form_book.Show();
        }

        private void btn_digital_Click(object sender, EventArgs e)
        {
            Form_Digital form_digital = new Form_Digital();
            form_digital.Show();
        }

        private void btn_members_Click(object sender, EventArgs e)
        {
            Form_Users form_users = new Form_Users();
            form_users.Show();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            Form_Borrow form_borrow = new Form_Borrow();
            form_borrow.Show();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            Form_Staff form_staff = new Form_Staff();
            form_staff.Show();
        }
    }

    public class FunctionsClass
    {
        static public string connstring
        {
            get => String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4}",
            "localhost", 5432, "postgres",
            "123456", "Project");
        }
        //static public NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public static string SelectContactStr(string table)
        {
            return $"select * from \"Contact_Info\" where exists(select* from \"{table}\" where \"Contact_Info\".contact_id = \"{table}\".contact_id order by \"{table}\".contact_id);";
        }

        public static void SelectData(string sql, DataGridView dgv, NpgsqlConnection conn) // update dgv
        {
            try
            {
                using var cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgv.DataSource = null; //reset dgv
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public static int GetCurrentRowIndex(DataGridView dgv)
        {
            return dgv.CurrentCell.RowIndex;
        }

        public static string GetColumnStr(DataGridView dgv, string column)
        {
            return dgv.Rows[GetCurrentRowIndex(dgv)].Cells[column].Value.ToString();
        }
    }
}
