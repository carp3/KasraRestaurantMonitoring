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

namespace KasraMonitoring
{
    public partial class Monitoring : Form
    {
        private int FishNo = 0;
        private int ID = 0;
        SqlCommand cmd;
        SqlConnection con;
        string date;
        string selecteddate;
        string Rest;
        string Term;
        string lastTerm = "";
        int searchIndex = 0;
        public Monitoring(SqlConnection connection,string rest,string term)
        {
            //TopMost = true;
            Rest = rest;
            Term = term;
            con = connection;
            cmd = new SqlCommand("SELECT SHDate  FROM [Framework].[Gnr].[Days] where CONVERT(date,Mdate) = CONVERT(date,getdate())",con);
            date = cmd.ExecuteScalar().ToString();
            selecteddate = date;
            InitializeComponent();
            dateLabel.Text = date;
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 6;


            cmd = new SqlCommand("SELECT SHDate  FROM [Framework].[Gnr].[Days] where DayID < (SELECT DayID  FROM [Framework].[Gnr].[Days] where CONVERT(date,Mdate) = CONVERT(date,getdate()))  ORDER BY DayID DESC  OFFSET 0 ROWS fetch next 7 rows only", con);
            using (var data = cmd.ExecuteReader())
            {

                while (true)
                    if (data.Read())
                    {
                        try
                        {
                            
                            comboBox3.Items.Add(data.GetString(data.GetOrdinal("SHDate")));
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    else break;
            }
            comboBox3.SelectedIndex = 0;

            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] list = new string[9];
            ListViewItem item;
            bool Updated = false;
            var term = "";
            if(Term != "خودکار") term = "AND FoodTermName = '" + Term  + "'";
            cmd = new SqlCommand("SELECT * FROM [Framework].[Rst].[Monitoring] WHERE OnlineUserID = 123456789 and ResturantName = '" + Rest + "' "+term+" AND ServeDate = '" + selecteddate + "' and ID > " + ID + " ORDER BY ID ASC  OFFSET 0 ROWS fetch next 100 rows only", con);
            using (var data = cmd.ExecuteReader())
            {

                while (true)
                    if (data.Read())
                    {
                        try
                        {
                            Updated = true;
                            list[1] = data.safeGetString(data.GetOrdinal("PersonID"));
                            list[2] = data.safeGetString(data.GetOrdinal("PersonName"));
                            list[3] = data.safeGetString(data.GetOrdinal("DeptName"));
                            list[4] = data.safeGetString(data.GetOrdinal("FoodName"));
                            list[5] = data.safeGetString(data.GetOrdinal("Time"));
                            list[6] = data.safeGetString(data.GetOrdinal("FoodTermName"));
                            list[7] = data.safeGetString(data.GetOrdinal("ResturantName"));
                            list[8] = data.safeGetString(data.GetOrdinal("StrError"));
                            lastTerm = data.safeGetString(data.GetOrdinal("FoodTermName"));
                            ID = data.GetInt32(data.GetOrdinal("ID"));
                            if (!data.IsDBNull(data.GetOrdinal("FishNo")))
                            {
                                FishNo = data.GetInt32(data.GetOrdinal("FishNo"));
                                list[0] = FishNo.ToString();
                            }else
                                list[0] = "-";
                                

                            
                        }
                        catch
                        {
                            continue;
                        }
                        finally
                        {

                            item = new ListViewItem(list);
                            listView1.Items.Insert(0, item);
                            pictureBox1.Image = null;
                            PictureUpdate.Stop();
                            PictureUpdate.Start();
                        }
                    }
                    else break;
            }
            var total = listView1.Items.Count;
            for (int i = total; i > 2000; i--)
                listView1.Items.RemoveAt(i-1);
            if (Updated)
            {
                FishNum.Text = list[0];
                PersonID.Text = list[1];
                PersonName.Text = list[2];
                DeptName.Text = list[3];
                FoodName.Text = list[4];
                Time.Text = list[5];
                FoodTerm.Text = list[6];
                RestName.Text = list[7];
                StrError.Text = list[8];
                if( list[8] != "مجاز به استفاده")
                    StrError.ForeColor = Color.Red;
                else
                    StrError.ForeColor = Color.MediumSeaGreen;
                
            }
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var mycmd = new SqlCommand(@"SELECT Count(FishNO) as t
  FROM [Framework].[Rst].[FoodUsage] where Date = '"+selecteddate+@"' AND CardReaderNo IN (SELECT CardReaderNo
  FROM [Framework].[Rst].[CardReader] left join 
  [Framework].[Rst].[CardReaderResturant] 
  on [Framework].[Rst].[CardReaderResturant].CardReaderID = [Framework].[Rst].[CardReader].CardReaderID left join   [Framework].[Rst].[Resturant]  on [Framework].[Rst].[CardReaderResturant].ResturantNo = [Framework].[Rst].[Resturant].ResturantNo Where [Framework].[Rst].[Resturant].ResturantName = 
  '" + Rest + "') And FoodTerm = (SELECT ID FROM [Framework].[Rst].[FoodTerm] Where FoodTermName = '" + lastTerm + "') group by PackID", con);
            var total = 0;
            var index = 0;
            var text = "";
            using (var data = mycmd.ExecuteReader())
            {

                while (true)
                    if (data.Read())
                    {
                        try
                        {
                            total += data.GetInt32(data.GetOrdinal("t"));
                            text += "غذای " + (++index) + ": " + data.GetInt32(data.GetOrdinal("t")) + "   ";
                            chart1.Series["Series1"].Points[index - 1].YValues[0] = data.GetInt32(data.GetOrdinal("t"));

                        }
                        catch
                        {
                            continue;
                        }
                        
                    }
                    else break;
            }
            Served.Text = total.ToString();
            ServedDetail.Text = text;
            chart1.Refresh();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var q = new SqlCommand("SELECT [Pic] FROM [AMANO].[AM51234].[amo].[Emp_01Photo] Where Emp_ID = '"+PersonID.Text+"'",con);
            try
            {
                byte[] res = (byte[])q.ExecuteScalar();
                using (MemoryStream str = new MemoryStream(res))
                {
                    pictureBox1.Image = Image.FromStream(str);
                }
            }
            catch {
                pictureBox1.Image = null;
            }

            PictureUpdate.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                        Reset();

            Rest = comboBox2.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                       Reset();

           Term = comboBox1.SelectedItem.ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dateUpdate_Tick(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT SHDate  FROM [Framework].[Gnr].[Days] where CONVERT(date,Mdate) = CONVERT(date,getdate())", con);
            date = cmd.ExecuteScalar().ToString();
            if (comboBox3.SelectedIndex == 0)
            {
                selecteddate = date;
                dateLabel.Text = date;
            }
            else
            {
                selecteddate = comboBox3.Text;
                dateLabel.Text = selecteddate;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchIndex = 0;
            Search();
            
        }

        private void Search()
        {
            var text = textBox1.Text.Replace('ی', 'ي').Replace('ک', 'ك');
            for (int i = 0; i < listView1.Items.Count; i++)
                listView1.Items[i].BackColor = Color.Transparent;
            var item = listView1.FindItemWithText(text, true, searchIndex, true);
            
            if (item != null)
            {
                searchIndex = item.Index+1;
                listView1.Items[item.Index].Selected = true;

                
                listView1.Items[item.Index].BackColor = Color.Yellow;
                listView1.EnsureVisible(item.Index);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = Color.Black;
            if (textBox1.Text == "جستجو...") textBox1.Text = "";
            button2.Visible = true;
                
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button2.Visible = false;
                this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;

                textBox1.Text = "جستجو...";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Search();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "جستجو...";
            for (int i = 0; i < listView1.Items.Count; i++)
                listView1.Items[i].BackColor = Color.Transparent;
            
            button2.Visible = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            Reset();
            if (comboBox3.SelectedIndex == 0)
            {
                selecteddate = date;
                dateLabel.Text = date;
            }
            else
            {
                selecteddate = comboBox3.Text;
                dateLabel.Text = selecteddate;
            }
            
        }

        private void Reset()
        {
            MonitroingUpdate.Enabled = false;
            dateUpdate.Enabled = false;
            SummeryUpdate.Enabled = false;
            textBox1.Text = "جستجو...";
            chart1.Series["Series1"].Points[0].YValues[0] = 0;
            chart1.Series["Series1"].Points[1].YValues[0] = 0;
            listView1.Items.Clear();

            
            button2.Visible = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            FishNo = 0;
            ID = 0;


            MonitroingUpdate.Enabled = true;
            dateUpdate.Enabled = true;
            SummeryUpdate.Enabled = true;

        }

        private void StrError_Click(object sender, EventArgs e)
        {

        }
    }
}
