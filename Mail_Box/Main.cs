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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Welcome_L.Text = "Welcome\n\"" + Global.loginUser + 
                "\"\n"+ "you have " + unreadCount() + "\nunread messages\nin your inbox";
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Global.loginUser == "admin") {
                allMessages_B.Visible = true;
                allUsers_B.Visible = true;
            }
        }

        private void Logout_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void Compose_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compose c = new Compose();
            c.ShowDialog();
            this.Close();
        }

        private void exit_b_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show(this,"Are you sure you want to exit?","Exit",MessageBoxButtons.YesNo)){
                case DialogResult.Yes:
                    this.Close();
                    break;
                default:
                    break;
            }
        }


        private void Inbox_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inbox i = new Inbox();
            try { i.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private int unreadCount() {
            SqlConnection conn = new SqlConnection(Global.connectionString);
            int count = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("unreadCount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Global.loginUser);
                count = (Int32)cmd.ExecuteScalar();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message);}
            finally { conn.Close(); }
            return count;
        }

        private void Sent_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sent i = new Sent();
            try { i.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void inTrash_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inbox_Trash i = new Inbox_Trash();
            try { i.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void seTrash_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sent_Trash i = new Sent_Trash();
            try { i.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void allMessages_B_Click(object sender, EventArgs e)
        {

        }

        private void allUsers_B_Click(object sender, EventArgs e)
        {

        }

        private void profile_B_Click(object sender, EventArgs e)
        {

        }
                        
    }
}
