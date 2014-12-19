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
    public partial class Inbox : Form
    {

        int type = 1;
        public Inbox()
        {
            InitializeComponent();
            getInbox();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void getInbox() {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showInbox", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Inbox_DGV.DataSource = dt;
                }

                Inbox_DGV.AllowUserToAddRows = false;
                Inbox_DGV.Columns["Date_Time"].Width = 120;
                Inbox_DGV.Columns["R"].Width = 18;
               
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                Inbox_DGV.Columns.Add(btn);
                btn.Text = "Attachments";
                btn.HeaderText = "Attachments";
                btn.Name = "Attachments";
                btn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                Inbox_DGV.Columns.Add(delete);
                delete.Text = "Delete";
                delete.HeaderText = "Delete";
                delete.Name = "Delete";
                delete.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn Reply_Forward = new DataGridViewButtonColumn();
                Inbox_DGV.Columns.Add(Reply_Forward);
                Reply_Forward.Text = "Reply/Forward";
                Reply_Forward.HeaderText = "Reply/Forward";
                Reply_Forward.Name = "Reply_Forward";
                Reply_Forward.UseColumnTextForButtonValue = true;

                Inbox_DGV.Width = Inbox_DGV.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                        + (Inbox_DGV.RowHeadersVisible ? Inbox_DGV.RowHeadersWidth : 0) -95;
                //Inbox_DGV.Height = Inbox_DGV.Rows.Cast<DataGridViewRow>().Sum(x => x.Height)
                          //  + (Inbox_DGV.ColumnHeadersVisible ? Inbox_DGV.ColumnHeadersHeight : 0) + 3;
                Inbox_DGV.Columns[0].Visible = false;
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (NullReferenceException ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("your inbox is empty!!!","Empty Inbox");
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
                this.Close();
            }
            finally { conn.Close(); }

            
        }

        private void Inbox_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                try
                {
                    string mid = Inbox_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    markAsReadMessage(mid);
                    this.Hide();
                    Attachments a = new Attachments(mid, type);
                    try { a.ShowDialog(); }
                    catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                    finally { this.Close(); }
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 7) {
                try
                {
                    string message = Inbox_DGV.Rows[e.RowIndex].Cells[7].Value.ToString();
                    Message_RTB.Text = message;
                    string mid = Inbox_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    markAsReadMessage(mid);
                    Inbox_DGV.Rows[e.RowIndex].Cells[4].Value = 1;
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 1) {
                try
                {
                    string mid = Inbox_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    switch (MessageBox.Show(this, "Are you sure you want to delete this message?", "deleting", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            deleteMessage(mid);
                            MessageBox.Show("your message added to inbox trash.");
                            this.Hide();
                            Inbox i = new Inbox();
                            i.ShowDialog();
                            this.Close();
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }


            if (e.ColumnIndex == 4) {
                try
                {
                    string mid = Inbox_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (Inbox_DGV.Rows[e.RowIndex].Cells[4].Value.ToString() == "False")
                    {
                        markAsReadMessage(mid);
                        Inbox_DGV.Rows[e.RowIndex].Cells[4].Value = 1;
                    }
                    else
                    {
                        markAsUnReadMessage(mid);
                        Inbox_DGV.Rows[e.RowIndex].Cells[4].Value = 0;
                    }
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 2) {
                try
                {
                    string mid = Inbox_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string senderuser = Inbox_DGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string subject = Inbox_DGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                    this.Hide();
                    Forward_Reply fr = new Forward_Reply(mid, senderuser, subject);
                    fr.ShowDialog();
                    this.Close();
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

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

        private void deleteMessage(string mid) {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("deleteInboxMessage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }

        private void markAsReadMessage(string mid) {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("markAsReadMessage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }

        private void markAsUnReadMessage(string mid)
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("markAsUnReadMessage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }

        private void SUnread_B_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showUnReadMessages", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Inbox_DGV.DataSource = dt;
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }

        private void showall_B_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showInbox", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Inbox_DGV.DataSource = dt;
                }
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
                else {
                    SqlConnection conn = new SqlConnection(Global.connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("searchInbox", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", Global.loginUser);
                        cmd.Parameters.AddWithValue("@searchType", searchBy_CB.Text);
                        cmd.Parameters.AddWithValue("@searchWord", Sword_TB.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            Inbox_DGV.DataSource = dt;
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
                        SqlCommand cmd = new SqlCommand("searchInboxbyDate", conn);
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
                            Inbox_DGV.DataSource = dt;
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

    
    }
}
