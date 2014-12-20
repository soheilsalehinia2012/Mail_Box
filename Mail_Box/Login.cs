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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_b_Click(object sender, EventArgs e)
        {
            string username = username_TB.Text;
            string password = password_TB.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please Enter Login Id and Password");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Global.connectionString);
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand("verifyUser", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@userName", username);
                    com.Parameters.AddWithValue("@password", password);
                    int usercount = (Int32)com.ExecuteScalar();
                    if (usercount == 1)
                    {
                        Global.loginUser = username;
                        Main m1 = new Main();
                        this.Hide();
                        try { m1.ShowDialog(); }
                        catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                        finally { this.Close(); }
                    }
                    else
                    {
                        username_TB.Clear();
                        password_TB.Clear();
                        MessageBox.Show("Username or Password is wrong...");
                    }
                }
                catch (SqlException ex) { Console.WriteLine(ex.Message); }
                finally {
                    username_TB.Clear();
                    password_TB.Clear();
                    conn.Close(); 
                }
            }
        }

        private void register_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            try { r.ShowDialog(); }
            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
            finally { this.Close(); }
        }

        private void password_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = username_TB.Text;
                string password = password_TB.Text;
                if (username == "" || password == "")
                {
                    MessageBox.Show("Please Enter Login Id and Password");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Global.connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand com = new SqlCommand("verifyUser", conn);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@userName", username);
                        com.Parameters.AddWithValue("@password", password);
                        int usercount = (Int32)com.ExecuteScalar();
                        if (usercount == 1)
                        {
                            Global.loginUser = username;
                            Main m1 = new Main();
                            this.Hide();
                            try { m1.ShowDialog(); }
                            catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                            finally { this.Close(); }
                        }
                        else
                        {
                            username_TB.Clear();
                            password_TB.Clear();
                            MessageBox.Show("Username or Password is wrong...");
                        }
                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        username_TB.Clear();
                        password_TB.Clear();
                        conn.Close();
                    }
                }
            }
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

        private void fpass_B_Click(object sender, EventArgs e)
        {

        }

    }
}
