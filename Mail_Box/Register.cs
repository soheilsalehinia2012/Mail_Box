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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void back_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void register_b_Click(object sender, EventArgs e)
        {
            string username = username_TB.Text;
            string password = password_TB.Text;
            string password2 = password2_TB.Text;
            string name = name_TB.Text;
            string fname = fname_TB.Text;
            if (username == "" || password == "" || password2 == "" || name == "" || fname == "")
            {
                MessageBox.Show("Please Fill * fields!");
            }
            else if (password != password2) {
                MessageBox.Show("passwords don't match!!!");
                password_TB.Clear();
                password2_TB.Clear();
            }
            else
            {
                SqlConnection conn = new SqlConnection(Global.connectionString);
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand("userCount", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@username", username);
                    int userCount = (Int32)com.ExecuteScalar();
                    if (userCount == 1)
                    {
                        MessageBox.Show("Username was taken, Please choose another Username...");
                        username_TB.Clear();
                    }
                    else
                    {
                        SqlCommand com2 = new SqlCommand("saveUser", conn);
                        com2.CommandType = CommandType.StoredProcedure;
                        com2.Parameters.AddWithValue("@username", username);
                        com2.Parameters.AddWithValue("@password", password);
                        com2.Parameters.AddWithValue("@name", name);
                        com2.Parameters.AddWithValue("@fname", fname);
                        com2.ExecuteNonQuery();
                        
                    }
                }
                catch (SqlException ex) { Console.WriteLine(ex.Message); }
                finally { 
                    conn.Close();
                    MessageBox.Show("You Successfully Registered");
                    this.Hide();
                    Login lg = new Login();
                    lg.ShowDialog();
                    this.Close();
                }
            }
        }

        private void exir_B_Click(object sender, EventArgs e)
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



        
    }
}
