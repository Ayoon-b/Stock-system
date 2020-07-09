using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_Host
{
    public partial class Country_Edit_Insert : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public Country_Edit_Insert()
        {
            InitializeComponent();

            bnt_confirm.BackgroundImage = Image.FromFile("confirm.png");
            bnt_confirm.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_cancel.BackgroundImage = Image.FromFile("cancel.png");
            bnt_cancel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Country_Edit_Insert_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=work_db;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(connStr);
        }

        private void bnt_confirm_Click(object sender, EventArgs e)
        {
            if (tb_country.Text.Equals(""))
            {
                MessageBox.Show("나라를 입력해주세요.", "삽입 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tb_avg.Text.Equals(""))
            {
                MessageBox.Show("매매기준율을 입력해주세요.", "삽입 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string country = tb_country.Text;
            string avg = tb_avg.Text;

            try
            {
                conn.Open();

                string insertQuery = "INSERT INTO country VALUES('" + country + "', " + avg + ")";

                cmd = new MySqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
