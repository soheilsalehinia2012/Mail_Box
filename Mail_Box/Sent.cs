using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mail_Box
{
    public partial class Sent : Form
    {
        int type = 2;
        public Sent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            getSent();
        }

        public void getSent() {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showSent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Sent_DGV.DataSource = dt;
                }

                Sent_DGV.AllowUserToAddRows = false;
                Sent_DGV.Columns["Date_Time"].Width = 120;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                Sent_DGV.Columns.Add(btn);
                btn.Text = "Attachments";
                btn.HeaderText = "Attachments";
                btn.Name = "Attachments";
                btn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                Sent_DGV.Columns.Add(delete);
                delete.Text = "Delete";
                delete.HeaderText = "Delete";
                delete.Name = "Delete";
                delete.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn forward = new DataGridViewButtonColumn();
                Sent_DGV.Columns.Add(forward);
                forward.Text = "Forward";
                forward.HeaderText = "Forward";
                forward.Name = "Forward";
                forward.UseColumnTextForButtonValue = true;

                Sent_DGV.Width = Sent_DGV.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                        + (Sent_DGV.RowHeadersVisible ? Sent_DGV.RowHeadersWidth : 0) - 95;
                Sent_DGV.Columns[0].Visible = false;
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("your sent is empty!!!", "Empty sent");
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
                this.Close();
            }
            finally { conn.Close(); }

        }

        private void back_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
            this.Close();
        }

        private void Logout_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void Sent_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string mid = Sent_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.Hide();
                    Attachments a = new Attachments(mid, type);
                    try { a.ShowDialog(); }
                    catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                    finally { this.Close(); }
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 6)
            {
                try
                {
                    string message = Sent_DGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                    Message_RTB.Text = message;
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 1)
            {
                try
                {
                    string mid = Sent_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    switch (MessageBox.Show(this, "Are you sure you want to delete this message?", "deleting", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            deleteMessage(mid);
                            MessageBox.Show("your message added to sent trash.");
                            this.Hide();
                            Sent i = new Sent();
                            i.ShowDialog();
                            this.Close();
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 2)
            {
                try
                {
                    string mid = Sent_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.Hide();
                    Forward f = new Forward(mid);
                    f.ShowDialog();
                    this.Close();
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }
        }

        private void deleteMessage(string mid)
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("deleteSentMessage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }

        private void searchBy_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchBy_CB.Text == "Date")
            {
                Sword_TB.Enabled = false;
                from_DTP.Enabled = true;
                to_DTP.Enabled = false;
            }
            else if (searchBy_CB.Text == "From..To Date")
            {
                Sword_TB.Enabled = false;
                from_DTP.Enabled = true;
                to_DTP.Enabled = true;
            }
            else
            {
                Sword_TB.Enabled = true;
                from_DTP.Enabled = false;
                to_DTP.Enabled = false;
            }
        }

        private void search_B_Click(object sender, EventArgs e)
        {
            if (searchBy_CB.Text == "")
            {
                MessageBox.Show("Please choose your type of search.");
            }
            else if (searchBy_CB.Text != "Date" && searchBy_CB.Text != "From..To Date")
            {
                if (Sword_TB.Text == "")
                {
                    MessageBox.Show("Please enter your search word.");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Global.connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("searchSent", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", Global.loginUser);
                        cmd.Parameters.AddWithValue("@searchType", searchBy_CB.Text);
                        cmd.Parameters.AddWithValue("@searchWord", Sword_TB.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            Sent_DGV.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Found Nothing!!!");
                        }
                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally { conn.Close(); }
                }
            }
            else
            {
                if (from_DTP.Value.Date > to_DTP.Value.Date.AddDays(1))
                {
                    MessageBox.Show("from date is after to date!!!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Global.connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("searchSentbyDate", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", Global.loginUser);
                        cmd.Parameters.Add("@fromdate", SqlDbType.DateTime).Value = from_DTP.Value.Date;
                        if (searchBy_CB.Text == "Date")
                            cmd.Parameters.Add("@todate", SqlDbType.DateTime).Value = from_DTP.Value.Date.AddDays(1);
                        else
                            cmd.Parameters.Add("@todate", SqlDbType.DateTime).Value = to_DTP.Value.Date.AddDays(1);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            Sent_DGV.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Found Nothing!!!");
                        }
                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally { conn.Close(); }
                }
            }
        }

        private void showA_B_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showSent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Sent_DGV.DataSource = dt;
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }

        
    }
}
