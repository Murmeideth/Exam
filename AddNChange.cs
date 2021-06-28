using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Demo
{
    public partial class AddNChange : Form
    {
        void do_Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!");
            }
        }

        string id;
        public AddNChange(string mode, string Id)
        {
            InitializeComponent();
            if (mode == "add")
            {
                button1.Text = "Добавить";
            }
            else if (mode == "chng")
            {
                button1.Text = "Изменить";
                id = Id;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Добавить")
            {
                string query = "insert into personal(name, id_sex, id_education, tel, email, id_position, bio) values('" + name_box.Text + "', (select id from sex where name = '" + sex_box.Text + "'), (select id from education where name = '" + education_box.Text + "'), '" + phone_box.Text + "', '" + mail_box.Text + "', (select id from position where name = '" + position_box.Text + "'), '" + bio_box.Text + "');";
                do_Action(query);
            }
            else if(button1.Text == "Изменить")
            {
                string query = "update personal set name = '" + name_box.Text + "', id_sex = (select id from sex where name = '" + sex_box.Text + "'), id_education = (select id from education where name = '" + education_box.Text + "'), tel = '" + phone_box.Text + "', email = '" + mail_box.Text + "', id_position = (select id from position where name = '" + position_box.Text + "'), bio = '" + bio_box.Text + "' where id = " + id + ";";
                do_Action(query);
            }
            Owner.Show();
            this.Close();
        }
    }
}
