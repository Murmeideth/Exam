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
    public partial class Personal : Form
    {
        public void get_info(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter data = new MySqlDataAdapter(query, conn);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                data.Fill(dt);
                list.DataSource = dt;
                list.ClearSelection();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("произошла ошибка загрузки данных");
            }
        }

        public void do_Action(string query)
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
                MessageBox.Show("Произшла непредвиденная ошибка!");
            }
        }

        public Personal()
        {
            InitializeComponent();
            string query = "select personal.id as '№ п/п', personal.name as 'ФИО', sex.name as 'Пол', education.name as 'Образование', personal.tel as 'Номер телефона', personal.email as 'Эл. почта', position.name as 'Должность', personal.bio as 'О себе' from " +
                "presonal join sex on sex.id = personal.id_sex join education on education.id = personal.id_education join position on position.id = personal.id_position;";
            get_info(query);
        }

        private void clear_search_Click(object sender, EventArgs e)
        {
            string query = "select personal.id as '№ п/п', personal.name as 'ФИО', sex.name as 'Пол', education.name as 'Образование', personal.tel as 'Номер телефона', personal.email as 'Эл. почта', position.name as 'Должность', personal.bio as 'О себе' from " +
                "presonal join sex on sex.id = personal.id_sex join education on education.id = personal.id_education join position on position.id = personal.id_position;";
            get_info(query);
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            string query = "select personal.id as '№ п/п', personal.name as 'ФИО', sex.name as 'Пол', education.name as 'Образование', personal.tel as 'Номер телефона', personal.email as 'Эл. почта', position.name as 'Должность', personal.bio as 'О себе' from " +
                "presonal join sex on sex.id = personal.id_sex join education on education.id = personal.id_education join position on position.id = personal.id_position where position.name like '%" + search_box.Text + "%';";
            get_info(query);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if(list.SelectedRows.Count > 1)
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите удалить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    string del = "delete from personal where id = " + list[0, list.CurrentRow.Index] + ";";
                    do_Action(del);
                }
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной записи! Удаление невозможно.");
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddNChange Win = new AddNChange("add", "");
            Win.Owner = this;
            Win.Show();
            this.Hide();
        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            if (list.CurrentRow.Selected)
            {
                AddNChange Win = new AddNChange("chng", list[0, list.CurrentRow.Index].Value.ToString());
                Win.Owner = this;
                Win.Show();
                this.Hide();
            }
        }
    }
}
