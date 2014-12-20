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
    public partial class Forward_Reply : Form
    {
        string mid;
        string senderuser;
        string subject;
        public Forward_Reply(string mid,string senderuser,string subject)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.mid = mid;
            this.senderuser = senderuser;
            this.subject = "Reply To ( " + subject + " )";
            showComboBox();
        }

        private void cancel_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inbox i = new Inbox();
            try { i.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void forward_B_Click(object sender, EventArgs e)
        {
            if (forward_CB.Text == "")
            {
                MessageBox.Show("Please choose the user you want to forward!!!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Global.connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("MessageForward", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", mid);
                    cmd.Parameters.AddWithValue("@username", Global.loginUser);
                    cmd.Parameters.AddWithValue("@recvuser", forward_CB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Message Forwarded to " + forward_CB.Text);
                    this.Hide();
                    Inbox i = new Inbox();
                    try { i.ShowDialog(); }
                    catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                    finally { this.Close(); }
                }
                catch (SqlException ex) { Console.WriteLine(ex.Message); }
                finally { conn.Close(); }
            }
        }

        private void reply_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compose c = new Compose(senderuser,subject);
            try { c.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void showComboBox()
        {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("getusernames", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Global.loginUser);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    forward_CB.Items.Add(reader["UserName"].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
