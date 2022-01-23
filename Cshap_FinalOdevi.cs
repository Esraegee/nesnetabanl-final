using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekTarifleriMyspl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string _server = "localhost";
            string _dbname = "DBYemekTarifi";
            string _username = "root";
            string _pass = "";

            string MySqlBaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_username};PWD={_pass}";

            using (var baglan = new MySqlConnection(MySqlBaglanti))
            {
                baglan.Open();
            }

        }
    }
}
