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
    public partial class Market_Form : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;

        private string selectQuery = "";

        public Market_Form()
        {
            InitializeComponent();

            bnt_select.BackgroundImage = Image.FromFile("select.png");
            bnt_select.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Market_Form_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=work_db;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                selectQuery = "SELECT * FROM worldmarket";

                cmd = new MySqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string name = rdr["marketName"].ToString();

                    combo_market.Items.Add(name);
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

            try
            {
                conn.Open();

                selectQuery = "SELECT DISTINCT theDate FROM fdailyquotation";

                cmd = new MySqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string date = rdr["theDate"].ToString();

                    combo_date.Items.Add(date);
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

        private void bnt_market_Click(object sender, EventArgs e)
        {
            Market_Edit _edit = new Market_Edit();
            _edit.ShowDialog();
        }

        private void bnt_select_Click(object sender, EventArgs e)
        {
            switch (mode_date.Checked)
            {
                case true:
                    {
                        if (combo_market.SelectedItem == null)
                            MessageBox.Show("해외증시를 선택해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (combo_date.SelectedItem == null)
                            MessageBox.Show("날짜를 선택해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            Select_Sql();
                        break;
                    }
                case false:
                    {
                        if (combo_market.SelectedItem == null)
                        {
                            MessageBox.Show("해외증시를 선택해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Select_Sql();
                        break;
                    }
                default:
                    break;
            }
        }

        private void Select_Sql()
        {
            datas.Rows.Clear();

            switch (mode_date.Checked)
            {
                case true:
                    selectQuery = "SELECT * FROM fdailyquotation WHERE marketName = '" + combo_market.Text + "'" +
                                            "AND theDate = '" + combo_date.Text + "'";
                    break;
                case false:
                    selectQuery = "SELECT * FROM fdailyquotation WHERE marketName = '" + combo_market.Text + "'";
                    break;
                default:
                    break;
            }

            try
            {
                conn.Open();

                cmd = new MySqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                { 
                    string date = rdr["theDate"].ToString();
                    string closeP = rdr["closeP"].ToString();
                    string compared = rdr["comparedPD"].ToString();
                    string marketP = rdr["marketP"].ToString();

                    datas.Rows.Add(date, closeP, compared, marketP);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void mode_date_CheckedChanged(object sender, EventArgs e)
        {
            if (mode_date.Checked)
            {
                date.Visible = true;
                combo_date.Visible = true;
            }
            else
            {
                date.Visible = false;
                combo_date.Visible = false;
            }
        }
    }
}
