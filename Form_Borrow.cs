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
    public partial class Form_Borrow : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        string selectB = @"Select * from ""Book""";
        string selectM = @"Select * from ""Member""";
        string selectC = @"Select * from ""Book_Copy""";
        string selectBorrow = @"Select * from ""Borrow_Info""";



        public Form_Borrow()
        {
            InitializeComponent();
        }

        private void Form_Borrow_Load(object sender, EventArgs e)
        {
            connection.Open();
            FunctionsClass.SelectData(selectB, dgv_book, connection);
            FunctionsClass.SelectData(selectM, dgv_memb, connection);
            FunctionsClass.SelectData(selectC, dgv_copies, connection);
            FunctionsClass.SelectData(selectBorrow, dgv_borrow, connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = $"insert into \"Borrow_Info\" (member_id, copy_id) values ({textBox2.Text}, {textBox1.Text})";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectBorrow, dgv_borrow, connection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = $"insert into \"Book_Copy\" (book_id) values ({textbox_bookid.Text})";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectC, dgv_copies, connection);
        }
    }
}
