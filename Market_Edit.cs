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
    public partial class Market_Edit : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;

        private string selectQuery = "";

        public Market_Edit()
        {
            InitializeComponent();

            bnt_select.BackgroundImage = Image.FromFile("select.png");
            bnt_select.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Market_Edit_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=work_db;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(connStr);
        }

        private void bnt_select_Click(object sender, EventArgs e)
        {
            datas.Rows.Clear();

            switch (mode_all.Checked)
            {
                case true:
                    {
                        selectQuery = "select w.marketName,w.countryName,w.AverCP,c.AverSRM from worldMarket w,country c " +
                            "where w.countryName=c.countryName;";
                        break;
                    }
                case false:
                    {
                        if (tb_market.Text.Equals(""))
                        {
                            MessageBox.Show("해외증시를 입력해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        selectQuery = "select w.marketName,w.countryName,w.AverCP,c.AverSRM " +
                            "from worldMarket w, country c where w.countryName = c.countryName and marketName like '%" + tb_market.Text + "%'";
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
                    string name = rdr["marketName"].ToString();
                    string Cname = rdr["countryName"].ToString();
                    string avg = rdr["AverCP"].ToString();
                    string Cavg =rdr["AverSRM"].ToString();

                    datas.Rows.Add(name,Cname, avg,Cavg);
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
                market.Visible = false;
                tb_market.Visible = false;
            }
            else
            {
                market.Visible = true;
                tb_market.Visible = true;
            }
        }
    }
}
