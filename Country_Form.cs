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
    public partial class Country_Form : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;

        private string cur_country = "";
        private string selectQuery = "";

        private int mode = 1;

        public Country_Form()
        {
            InitializeComponent();

            bnt_select.BackgroundImage = Image.FromFile("select.png");
            bnt_select.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_insert.BackgroundImage = Image.FromFile("insert.png");
            bnt_insert.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_update.BackgroundImage = Image.FromFile("update.png");
            bnt_update.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_delete.BackgroundImage = Image.FromFile("delete.png");
            bnt_delete.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Country_Form_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=work_db;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                selectQuery = "SELECT * FROM country";

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

            try
            {
                conn.Open();

                selectQuery = "SELECT DISTINCT theDate FROM cdailyquotation";

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

        private void bnt_country_Click(object sender, EventArgs e)
        {
            Country_Edit _edit = new Country_Edit();
            _edit.ShowDialog();
        }

        private void bnt_select_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    {
                        if (combo_country.SelectedItem == null)
                        {
                            MessageBox.Show("나라를 선택해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cur_country = combo_country.Text;
                        Select_Sql();
                        break;
                    }
                case 2:
                    {
                        if (combo_country.SelectedItem == null)
                            MessageBox.Show("나라를 선택해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (combo_date.SelectedItem == null)
                            MessageBox.Show("날짜를 선택해주세요.", "검색 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            cur_country = combo_country.Text;
                            Select_Sql();
                        }
                        break;
                    }
                case 3:
                    {
                        cur_country = combo_country.Text;
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

            switch (mode)
            {
                case 1:
                    columns_Edit();
                    selectQuery = "SELECT * FROM cdailyquotation WHERE countryName = '" + cur_country + "'";
                    break;
                case 2:
                    columns_Edit();
                    selectQuery = "SELECT * FROM cdailyquotation WHERE countryName = '" + cur_country + "'" +
                                            "AND theDate = '" + combo_date.Text + "'";
                    break;
                case 3:
                    {
                        datas.Columns.Clear();
                        
                        datas.Columns.Add("c1", "나라");
                        DataGridViewColumn c1 = datas.Columns[0];
                        datas.Columns.Add("c2", "월간 최대 매매기준율");
                        DataGridViewColumn c2 = datas.Columns[1];
                        datas.Columns.Add("c3", "월간 최소 매매기준율");
                        DataGridViewColumn c3 = datas.Columns[2];
                        c2.Width = c3.Width = 220;

                        selectQuery = "SELECT countryName, Max(TraingRate), Min(TraingRate) " +
                                                "FROM cdailyquotation group by countryName";
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

                switch (mode)
                {
                    case 1:
                        {
                            while (rdr.Read())
                            {
                                string date = rdr["theDate"].ToString();
                                string rate = rdr["TraingRate"].ToString();
                                string compared = rdr["comparedPD"].ToString();
                                string cash_buy = rdr["cash_buy"].ToString();
                                string cash_sold = rdr["cash_sold"].ToString();

                                datas.Rows.Add(date, rate, compared, cash_buy, cash_sold);
                            }
                            break;
                        }
                    case 2:
                        {
                            while (rdr.Read())
                            {
                                string date = rdr["theDate"].ToString();
                                string rate = rdr["TraingRate"].ToString();
                                string compared = rdr["comparedPD"].ToString();
                                string cash_buy = rdr["cash_buy"].ToString();
                                string cash_sold = rdr["cash_sold"].ToString();

                                datas.Rows.Add(date, rate, compared, cash_buy, cash_sold);
                            }
                            break;
                        }
                    case 3:
                        {
                            while (rdr.Read())
                            {
                                string country = rdr["countryName"].ToString();
                                string Max = rdr["Max(TraingRate)"].ToString();
                                string Min = rdr["Min(TraingRate)"].ToString();

                                datas.Rows.Add(country, Max, Min);
                            }
                            break;
                        }
                    default:
                        break;
                }

                while (rdr.Read())
                {
                    string date = rdr["theDate"].ToString();
                    string rate = rdr["TraingRate"].ToString();
                    string compared = rdr["comparedPD"].ToString();
                    string cash_buy = rdr["cash_buy"].ToString();
                    string cash_sold = rdr["cash_sold"].ToString();

                    datas.Rows.Add(date, rate, compared, cash_buy, cash_sold);
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

        private void bnt_insert_Click(object sender, EventArgs e)
        {
            Country_Insert _insert = new Country_Insert();
            _insert.ShowDialog();
        }

        private void bnt_update_Click(object sender, EventArgs e)
        {
            if (datas.Rows.Count < 1) return;

            string date = datas.SelectedRows[0].Cells[0].Value.ToString();
            Country_Update _update = new Country_Update(cur_country, date);

            _update.ShowDialog();
        }

        private void bnt_delete_Click(object sender, EventArgs e)
        {
            if (datas.Rows.Count < 1) return;

            string date = datas.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show(cur_country + " : " + date + " 날짜의 데이터를 삭제하시겠습니까?",
                "행삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    datas.Rows.RemoveAt(datas.SelectedRows[0].Index);
                    delete_Sql(date);
                }
                catch
                {
                    MessageBox.Show("유효한 데이터를 선택해주세요.", "삭제 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void delete_Sql(string date)
        {
            try
            {
                conn.Open();
                string deleteQuery = "DELETE FROM cdailyquotation " +
                       "WHERE countryName = '" + cur_country + "' AND theDate = '" + date + "'";

                cmd = new MySqlCommand(deleteQuery, conn);
                cmd.ExecuteNonQuery();
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

        private void mode_date_CheckedChanged(object sender, EventArgs e)
        {
            if (mode_date.Checked)
            {
                date.Visible = true;
                combo_date.Visible = true;
                mode_month.Checked = false;
            }
            else
            {
                date.Visible = false;
                combo_date.Visible = false;
            }
        }

        private void mode_month_CheckedChanged(object sender, EventArgs e)
        {
            if (mode_month.Checked)
            {
                bnt_delete.Enabled = false;
                bnt_update.Enabled = false;
                combo_country.Text = null;
                combo_country.Enabled = false;
                mode_date.Checked = false;
            }
            else
            {
                bnt_delete.Enabled = true;
                bnt_update.Enabled = true;
                combo_country.Enabled = true;
            }
        }

        private void columns_Edit()
        {
            datas.Columns.Clear();

            datas.Columns.Add("c1", "날짜");
            DataGridViewColumn c1 = datas.Columns[0];
            datas.Columns.Add("c2", "매매기준율");
            DataGridViewColumn c2 = datas.Columns[1];
            datas.Columns.Add("c3", "전일대비");
            DataGridViewColumn c3 = datas.Columns[2];
            datas.Columns.Add("c4", "현찰 (살 때)");
            DataGridViewColumn c4 = datas.Columns[3];
            datas.Columns.Add("c5", "현찰 (팔 때)");
            DataGridViewColumn c5 = datas.Columns[4];

            c1.Width = 130; c3.Width = 105;
            c2.Width = c4.Width = c5.Width = 115;
        }

        private void Country_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode_date.Checked)
                mode = 2;
            else if (mode_month.Checked)
                mode = 3;
            else
                mode = 1;
        }
    }
}