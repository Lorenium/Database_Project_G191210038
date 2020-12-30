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
    public partial class Form_Digital : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection(FunctionsClass.connstring);
        private string sql;
        private string selectDoc = @"SELECT * FROM ONLY ""Digital_Material"" NATURAL FULL JOIN  ""Documentary"" WHERE ""Digital_Material"".""digital_id"" = ""Documentary"".""digital_id""";
        private string selectCourse = @"SELECT * FROM ONLY ""Digital_Material"" NATURAL FULL JOIN  ""Course"" WHERE ""Digital_Material"".""digital_id"" = ""Course"".""digital_id""";


        public Form_Digital()
        {
            InitializeComponent();
        }

        private void Form_Digital_Load(object sender, EventArgs e)
        {
            connection.Open();
            FunctionsClass.SelectData(selectDoc, dgv_documentary, connection);
            FunctionsClass.SelectData(selectCourse, dgv_course, connection);
        }

        private void btn_add_documentary_Click(object sender, EventArgs e)
        {
            //string title = FunctionsClass.GetColumnStr(dgv_books, "title");
            //string edition = FunctionsClass.GetColumnStr(dgv_books, "edition");
            //string category = FunctionsClass.GetColumnStr(dgv_books, "category");
            string[] values = new string[6];
            string[] prmNames = new string[] {"section_id", "title", "URL", "director", "duration", "subject" };
            var prmNamesC = String.Join(",", prmNames);

            for (int i = 0; i < 6; i++)
                values[i] = FunctionsClass.GetColumnStr(dgv_documentary, prmNames[i]);

            //sql = $"insert into \"Digital_Material\" ({prmNames[0]}, {prmNames[1]}, \"{prmNames[2]}\") values ('{values[0]}','{values[1]}','{values[2]}'; insert into \"Documentary\" (digital_id, {prmNames[3]}, {prmNames[4]}, {prmNames[5]})" +
            //    $"values ({values[3]},'{values[4]}','{values[5]}')";

             sql = $"select* from documentary_add({values[0]},'{values[1]}','{values[2]}','{values[3]}','{values[4]}','{values[5]}')";

            try
            {
                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                FunctionsClass.SelectData(selectDoc, dgv_documentary, connection);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_delete_documentary_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Documentary\" where digital_id = {FunctionsClass.GetColumnStr(dgv_documentary, "digital_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectDoc, dgv_documentary, connection);
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            string[] values = new string[6];
            string[] prmNames = new string[] { "section_id", "title", "URL", "tutor", "video_count", "field" };
            var prmNamesC = String.Join(",", prmNames);

            for (int i = 0; i < 6; i++)
                values[i] = FunctionsClass.GetColumnStr(dgv_course, prmNames[i]);

            //sql = $"insert into \"Digital_Material\" ({prmNames[0]}, {prmNames[1]}, \"{prmNames[2]}\") values ('{values[0]}','{values[1]}','{values[2]}'; insert into \"Documentary\" (digital_id, {prmNames[3]}, {prmNames[4]}, {prmNames[5]})" +
            //    $"values ({values[3]},'{values[4]}','{values[5]}')";

            sql = $"select* from course_add({values[0]},'{values[1]}','{values[2]}','{values[3]}','{values[4]}','{values[5]}')";

            try
            {
                using var cmd = new NpgsqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                FunctionsClass.SelectData(selectCourse, dgv_course, connection);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            FunctionsClass.SelectData(selectCourse, dgv_course, connection);
        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            sql = $"delete from \"Course\" where digital_id = {FunctionsClass.GetColumnStr(dgv_course, "digital_id")}";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            FunctionsClass.SelectData(selectCourse, dgv_course, connection);
        }
    }
}
