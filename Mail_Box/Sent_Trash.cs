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
    public partial class Sent_Trash : Form
    {
        int type = 4;
        public Sent_Trash()
        {
            InitializeComponent();
            getSentTrash();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void getSentTrash() {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showTrashSent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    SentTrash_DGV.DataSource = dt;
                }

                SentTrash_DGV.AllowUserToAddRows = false;
                SentTrash_DGV.Columns["Date_Time"].Width = 120;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                SentTrash_DGV.Columns.Add(btn);
                btn.Text = "Attachments";
                btn.HeaderText = "Attachments";
                btn.Name = "Attachments";
                btn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                SentTrash_DGV.Columns.Add(delete);
                delete.Text = "Delete";
                delete.HeaderText = "Delete";
                delete.Name = "Delete";
                delete.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn undelete = new DataGridViewButtonColumn();
                SentTrash_DGV.Columns.Add(undelete);
                undelete.Text = "unDelete";
                undelete.HeaderText = "unDelete";
                undelete.Name = "unDelete";
                undelete.UseColumnTextForButtonValue = true;

                SentTrash_DGV.Width = SentTrash_DGV.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                        + (SentTrash_DGV.RowHeadersVisible ? SentTrash_DGV.RowHeadersWidth : 0) - 95;
                SentTrash_DGV.Columns[0].Visible = false;
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("your sent trash is empty!!!", "Empty Sent Trash");
                this.Hide();
                Main m = new Main();
                try { m.ShowDialog(); }
                catch (ObjectDisposedException ex2) { Console.WriteLine(ex2.Message); }
                finally { this.Close(); }
            }
            finally { conn.Close(); }
        }

        private void back_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            try { m.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void Logout_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            try { lg.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
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

        private void showall_B_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showTrashSent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    SentTrash_DGV.DataSource = dt;
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
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
                        SqlCommand cmd = new SqlCommand("searchSentTrash", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", Global.loginUser);
                        cmd.Parameters.AddWithValue("@searchType", searchBy_CB.Text);
                        cmd.Parameters.AddWithValue("@searchWord", Sword_TB.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            SentTrash_DGV.DataSource = dt;
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
                        SqlCommand cmd = new SqlCommand("searchSentTrashbyDate", conn);
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
                            SentTrash_DGV.DataSource = dt;
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

        private void SentTrash_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string mid = SentTrash_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                    string message = SentTrash_DGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                    Message_RTB.Text = message;
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 1)
            {
                try
                {
                    string mid = SentTrash_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    switch (MessageBox.Show(this, "Are you sure you want to delete this message?\nIt Will be deleted completely!!!"
                        , "deleting", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            deleteMessage(mid);
                            MessageBox.Show("your message deleted completely.");
                            this.Hide();
                            Sent_Trash i = new Sent_Trash();
                            try { i.ShowDialog(); }
                            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                            finally { this.Close(); }
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
                    string mid = SentTrash_DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    SqlConnection conn = new SqlConnection(Global.connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("undeleteSentMessage", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("your message undeleted.");
                        this.Hide();
                        Sent_Trash i = new Sent_Trash();
                        try { i.ShowDialog(); }
                        catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                        finally { this.Close(); }
                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally { conn.Close(); }
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
                SqlCommand cmd = new SqlCommand("deleteSentMessageCompletly", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("deleteMessageCompletly", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
