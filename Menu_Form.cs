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
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();

            bnt_country.BackgroundImage = Image.FromFile("bnt_country.png");
            bnt_country.BackgroundImageLayout = ImageLayout.Stretch;

            bnt_market.BackgroundImage = Image.FromFile("bnt_market.png");
            bnt_market.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bnt_country_Click(object sender, EventArgs e)
        {
            Country_Form form_country = new Country_Form();
            form_country.Show();
        }

        private void bnt_market_Click(object sender, EventArgs e)
        {
            Market_Form form_market = new Market_Form();
            form_market.Show();
        }
    }
}