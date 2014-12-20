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
using System.IO;

namespace Mail_Box
{
    public partial class Attachments : Form
    {
        string MID;
        int type = 0;
        public Attachments(string MID, int type)
        {
            InitializeComponent();
            this.MID = MID;
            this.type = type;
            getAttachments();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        public void getAttachments() {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("showAttachments", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", MID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Attachments_DGV.DataSource = dt;
                }
                Attachments_DGV.AllowUserToAddRows = false;
                Attachments_DGV.Columns["filename"].Width = 250;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                Attachments_DGV.Columns.Add(btn);
                btn.Text = "download";
                btn.HeaderText = "download";
                btn.Name = "download";
                btn.UseColumnTextForButtonValue = true;

                Attachments_DGV.Width = Attachments_DGV.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                        + (Attachments_DGV.RowHeadersVisible ? Attachments_DGV.RowHeadersWidth : 0) - 95;
                Attachments_DGV.Height = Attachments_DGV.Rows.Cast<DataGridViewRow>().Sum(x => x.Height)
                        + (Attachments_DGV.ColumnHeadersVisible ? Attachments_DGV.ColumnHeadersHeight : 0) + 3;
                Attachments_DGV.Columns[0].Visible = false;

            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No Attachments", "No Attachments");
                if (type == 1)
                {
                    this.Hide();
                    Inbox i = new Inbox();
                    try { i.ShowDialog(); }
                    catch (ObjectDisposedException ex2) { Console.WriteLine(ex2.Message); }
                    finally { this.Close(); }
                }
                if (type == 2)
                {
                    this.Hide();
                    Sent s = new Sent();
                    try { s.ShowDialog(); }
                    catch (ObjectDisposedException ex2) { Console.WriteLine(ex2.Message); }
                    finally { this.Close(); }
                }
                if (type == 3)
                {
                    this.Hide();
                    Inbox_Trash s = new Inbox_Trash();
                    try { s.ShowDialog(); }
                    catch (ObjectDisposedException ex2) { Console.WriteLine(ex2.Message); }
                    finally { this.Close(); }
                }
                if (type == 4)
                {
                    this.Hide();
                    Sent_Trash s = new Sent_Trash();
                    try { s.ShowDialog(); }
                    catch (ObjectDisposedException ex2) { Console.WriteLine(ex2.Message); }
                    finally { this.Close(); }
                }
            }
            finally { conn.Close(); }
            
        }


        private void back_B_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                this.Hide();
                Inbox i = new Inbox();
                try { i.ShowDialog(); }
                catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                finally { this.Close(); }
            }
            if (type == 2)
            {
                this.Hide();
                Sent i = new Sent();
                try { i.ShowDialog(); }
                catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                finally { this.Close(); }
            }
            if (type == 3)
            {
                this.Hide();
                Inbox_Trash s = new Inbox_Trash();
                try { s.ShowDialog(); }
                catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                finally { this.Close(); }
            }
            if (type == 4)
            {
                this.Hide();
                Sent_Trash s = new Sent_Trash();
                try { s.ShowDialog(); }
                catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                finally { this.Close(); }
            }
        }

        private void logout_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            try { lg.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void exit_B_Click(object sender, EventArgs e)
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

        private void Attachments_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                try
                {
                    byte[] bytes = (byte[])Attachments_DGV.Rows[e.RowIndex].Cells[1].Value;
                    string filename = Attachments_DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string Path = folderPath + "\\Mail_Box_Attachments\\" + Global.loginUser + "\\";
                    Directory.CreateDirectory(Path);
                    File.WriteAllBytes(Path + filename, bytes);
                    MessageBox.Show("It saved in " + Path);
                    System.Diagnostics.Process.Start("explorer.exe", @"" + Path);
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }

            if (e.ColumnIndex == 4) {
                try
                {
                    string des = Attachments_DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                    descriotion_RTB.Text = des;
                }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            }
        }


    }
}
