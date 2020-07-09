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
    public partial class Country_Edit : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;
        
        private string selectQuery = "";

        public Country_Edit()
        {
            InitializeComponent();

            bnt_select.BackgroundImage = Image.FromFile("select.png");
            bnt_select.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_insert.BackgroundImage = Image.FromFile("insert.png");
            bnt_insert.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Country_Edit_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=work_db;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(connStr);
        }

        private void bnt_insert_Click(object sender, EventArgs e)
        {
            Country_Edit_Insert _edit_insert = new Country_Edit_Insert();
            _edit_insert.ShowDialog();
        }

        private void bnt_select_Click(object sender, EventArgs e)
        {
            datas.Rows.Clear();

            switch (mode_all.Checked)
            {
                case true:
                    {
                        selectQuery = "SELECT * FROM country";
                        break;
                    }
                case false:
                    {
                        if (tb_country.Text.Equals(""))
                        {
                            MessageBox.Show("나라를 입력해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        selectQuery = "SELECT * FROM country WHERE countryName like '%" + tb_country.Text + "%'";
                        break;
                    }
                default:
                    break;
            }

            try
            {
                conn.Open();

                cmd = new MySqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string name = rdr["countryName"].ToString();
                    string avg = rdr["AverSRM"].ToString();

                    datas.Rows.Add(name, avg);
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

        private void mode_all_CheckedChanged(object sender, EventArgs e)
        {
            if (mode_all.Checked)
            {
                country.Visible = false;
                tb_country.Visible = false;
            }
            else
            {
                country.Visible = true;
                tb_country.Visible = true;
            }
        }
    }
}