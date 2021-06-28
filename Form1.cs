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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from users where login = '" + log_box.Text + "' and password = '" + pass_box.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();

                if (rd.HasRows)
                {
                    rd.Read();
                    int Count = Convert.ToInt32(rd.GetInt32(0));
                    if (Count > 0)
                    {
                        Personal Win = new Personal();
                        Win.Owner = this;
                        Win.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации!");
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка авторизации!");
            }
        }
    }
}
