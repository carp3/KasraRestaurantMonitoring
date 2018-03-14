using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KasraMonitoring
{
    public partial class MainForm : Form
    {
        string configFile;
        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var configFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "KasraMonitoring");
            if (!Directory.Exists(configFolder)){
                Directory.CreateDirectory(configFolder);
            }
            configFile = Path.Combine(configFolder, "database.conf");

            if(File.Exists(configFile)){
                var Config = File.ReadAllText(configFile);
                ShowMainForm(Config);
            }


        }

        private void ShowMainForm(string Config)
        {

            try
            {
                SqlConnection con = new SqlConnection(Config);
                con.Open();
                var a = new Monitoring(con, "رستوران مركزي", "خودکار");
                a.ShowDialog(this);

            }
            catch (Exception er)
            {
                MessageBox.Show("خطا در اتصال ... \r\n" + er, ToString());
            }
            finally
            {
                Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(configFile, textBox1.Text);
            try
            {
                var test = new SqlConnection(textBox1.Text);
                test.Open();
                test.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("خطا در اتصال ... \r\n" + er, ToString());
                return;
            }
            File.WriteAllText(configFile, textBox1.Text);
            ShowMainForm(textBox1.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




    }
}
