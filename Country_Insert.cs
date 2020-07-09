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
    public partial class Country_Insert : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;

        public Country_Insert()
        {
            InitializeComponent();

            bnt_confirm.BackgroundImage = Image.FromFile("confirm.png");
            bnt_confirm.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_cancel.BackgroundImage = Image.FromFile("cancel.png");
            bnt_cancel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Country_Insert_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=work_db;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string selectQuery = "SELECT * FROM country";

                cmd = new MySqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string name = rdr["countryName"].ToString();

                    combo_country.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bnt_confirm_Click(object sender, EventArgs e)
        {
            if (combo_country.Text.Equals(""))
            {
                MessageBox.Show("나라를 선택해주세요.", "삽입 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tb_date.Text.Equals(""))
            {
                MessageBox.Show("날짜를 입력해주세요.", "삽입 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tb_rate.Text.Equals(""))
            {
                MessageBox.Show("매매기준율을 입력해주세요.", "삽입 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string country = combo_country.Text;
            string date = tb_date.Text;
            string rate = tb_rate.Text;
            string compared = tb_compared.Text.Equals("") ? "null" : tb_compared.Text;
            string cash_buy = tb_cash_buy.Text.Equals("") ? "null" : tb_cash_buy.Text;
            string cash_sold = tb_cash_sold.Text.Equals("") ? "null" : tb_cash_sold.Text;

            try
            {
                conn.Open();

                string insertQuery = "INSERT INTO cdailyquotation VALUES('" + country + "', '" + date + "', "
                    + rate + ", " + compared + ", " + cash_buy + ", " + cash_sold + ")";

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