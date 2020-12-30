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
    public partial class Form_Book : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string select_book = @"select * from ""Book""";
        string select_author = @"select * from ""Author""";
        string select_publisher = @"select * from ""Publisher""";

        public Form_Book()
        {
            InitializeComponent();
        }

        private void Form_Book_Load(object sender, EventArgs e)
        {
            connection.Open();
            // show books authors and publishers
            FunctionsClass.SelectData(select_book, dgv_books, connection);
            FunctionsClass.SelectData(select_author, dgv_authors, connection);
            FunctionsClass.SelectData(select_publisher, dgv_publishers, connection);
        }

        private void btn_add_author_Click(object sender, EventArgs e)
        {
            sql = @"select * from author_insert(:_name, :_surname);";

            using var cmd = new NpgsqlCommand(sql, connection);
            //var rowIndex = dgv_authors.CurrentCell.RowIndex;
            cmd.Parameters.AddWithValue("_name", FunctionsClass.GetColumnStr(dgv_authors, "first_name"));
            cmd.Parameters.AddWithValue("_surname", FunctionsClass.GetColumnStr(dgv_authors, "last_name"));
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(select_author, dgv_authors, connection);
        }

        private void btn_delete_author_Click(object sender, EventArgs e)
        {
            sql = @"select * from author_delete(:_id)";
            using var cmd = new NpgsqlCommand(sql, connection);
            //var rowIndex = dgv_authors.CurrentCell.RowIndex;
            cmd.Parameters.AddWithValue("_id", Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_authors, "author_id")));
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(select_author, dgv_authors, connection);
        }

        private void btn_add_publisher_Click(object sender, EventArgs e)
        {
            sql = @"select * from publisher_insert(:_contact_id, :_name)";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("_contact_id", Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_publishers, "contact_id")));
            cmd.Parameters.AddWithValue("_name", FunctionsClass.GetColumnStr(dgv_publishers, "name"));
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(select_publisher, dgv_publishers, connection);
        }

        private void btn_contact_publisher_Click(object sender, EventArgs e)
        {
            Form_Contacts form_contacts = new Form_Contacts("Publisher");
            form_contacts.ShowDialog();
            //var current_row = FunctionsClass.GetCurrentRowIndex(dgv_publishers);
            //dgv_publishers.Rows[current_row].Cells["contact_id"].Value = form_contacts.selectedContactId;
            //dgv_publishers.Rows[current_row + 1].Cells["contact_id"].Selected = false;
            //dgv_publishers.CurrentCell = dgv_publishers.Rows[current_row + 1].Cells["name"];
            //dgv_publishers.BeginEdit(true);
        }

        private void btn_delete_publisher_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Publisher\" where publisher_id = {FunctionsClass.GetColumnStr(dgv_publishers,"publisher_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            //var rowIndex = dgv_authors.CurrentCell.RowIndex;
            //cmd.Parameters.AddWithValue("_id", Convert.ToInt32());
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(select_publisher, dgv_publishers, connection);
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            int author_id = Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_books, "author_id"));
            int section_id = Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_books, "section_id"));
            int publisher_id = Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_books, "publisher_id"));
            int page_count = Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_books, "page_count"));
            int price = Convert.ToInt32(FunctionsClass.GetColumnStr(dgv_books, "price"));
            string title = FunctionsClass.GetColumnStr(dgv_books, "title");
            string edition = FunctionsClass.GetColumnStr(dgv_books, "edition");
            string category = FunctionsClass.GetColumnStr(dgv_books, "category");

            sql = $"insert into \"Book\" (author_id,section_id,publisher_id,page_count,price,title,edition,category)" +
                $" values({author_id}, {section_id}, {publisher_id}, {page_count}, {price}, '{title}', '{edition}', '{category}' ); ";

            using var cmd = new NpgsqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            FunctionsClass.SelectData(select_book, dgv_books, connection);
        }

        private void btn_delete_book_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Book\" where book_id = {FunctionsClass.GetColumnStr(dgv_books, "book_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        private void btn_update_book_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_author_Click(object sender, EventArgs e)
        {

        }
    }
}
