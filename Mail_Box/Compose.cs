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
    public partial class Compose : Form
    {
        byte[] bytes1, bytes2, bytes3;
        string filename1, filename2, filename3;
        int size1, size2, size3;
        public Compose()
        {
            InitializeComponent();
            showComboBox();
            bytes1 = null;
            bytes2 = null;
            bytes3 = null;
            filename1 = null;
            filename2 = null;
            filename3 = null;
            size1 = -1;
            size2 = -1;
            size3 = -1;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Compose(string sendto,string subject)
        {
            InitializeComponent();
            showComboBox();
            bytes1 = null;
            bytes2 = null;
            bytes3 = null;
            filename1 = null;
            filename2 = null;
            filename3 = null;
            size1 = -1;
            size2 = -1;
            size3 = -1;
            this.StartPosition = FormStartPosition.CenterScreen;
            sendto_CB.Text = sendto;
            subject_TB.Text = subject;
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
        private void showComboBox() {
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
                    sendto_CB.Items.Add(reader["UserName"].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close();}
        }

        private void Attach1_B_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                string file = openFileDialog1.FileName;
                filename1 = openFileDialog1.SafeFileName;
                try
                {
                    bytes1 = File.ReadAllBytes(file);
                    size = bytes1.Length;
                    result1_L.Text = file + " (" + size + " Bytes)";
                    size1 = size;
                }
                catch (IOException ex) { Console.WriteLine(ex.Message); } 
                
            }
            
        }

        private void Attach2_B_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog2.FileName;
                filename2 = openFileDialog2.SafeFileName;
                try
                {
                    bytes2 = File.ReadAllBytes(file);
                    size = bytes2.Length;
                    result2_L.Text = file + " (" + size + " Bytes)";
                    size2 = size;
                }
                catch (IOException ex) { Console.WriteLine(ex.Message); }
            }
        }

        private void Attach3_B_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog3.FileName;
                filename3 = openFileDialog3.SafeFileName;
                try
                {
                    bytes3 = File.ReadAllBytes(file);
                    size = bytes3.Length;
                    result3_L.Text = file + " (" + size + " Bytes)";
                    size3 = size;
                }
                catch (IOException ex) { Console.WriteLine(ex.Message); }
            }
        }


        private void send_B_Click(object sender, EventArgs e)
        {
            string sendTo = sendto_CB.Text;
            string subject = subject_TB.Text;
            string message = Message_RTB.Text;
            string des1 = des1_TB.Text;
            string des2 = des2_TB.Text;
            string des3 = des3_TB.Text;
            if (sendTo == "") { MessageBox.Show("Please Enter sendTo username!"); }
            else
            {
                if (subject_TB.Text == "" || Message_RTB.Text == "")
                {
                    switch (MessageBox.Show(this, "Are you sure you want send your message without subject or text?",
                        "empty subject//text", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            SqlConnection conn = new SqlConnection(Global.connectionString);
                            try
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("saveMessage", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                if (subject != "")
                                    cmd.Parameters.AddWithValue("@subject", subject);
                                if (message != "")
                                    cmd.Parameters.AddWithValue("@text", message);
                                cmd.Parameters.AddWithValue("@senderuser", Global.loginUser);
                                cmd.Parameters.AddWithValue("@receiveruser", sendTo);
                                cmd.Parameters.AddWithValue("@attach1", bytes1);
                                cmd.Parameters.AddWithValue("@attach2", bytes2);
                                cmd.Parameters.AddWithValue("@attach3", bytes3);
                                if (des1 != "")
                                    cmd.Parameters.AddWithValue("@des1", des1);
                                if (des2 != "")
                                    cmd.Parameters.AddWithValue("@des2", des2);
                                if (des3 != "")
                                    cmd.Parameters.AddWithValue("@des3", des3);
                                cmd.Parameters.AddWithValue("@filename1", filename1);
                                cmd.Parameters.AddWithValue("@filename2", filename2);
                                cmd.Parameters.AddWithValue("@filename3", filename3);
                                if (size1 != -1)
                                    cmd.Parameters.AddWithValue("@size1", size1);
                                if (size2 != -1)
                                    cmd.Parameters.AddWithValue("@size2", size2);
                                if (size3 != -1)
                                    cmd.Parameters.AddWithValue("@size3", size3);
                                cmd.ExecuteNonQuery();

                            }
                            catch (SqlException ex) { Console.WriteLine(ex.Message); }
                            finally
                            {
                                conn.Close();
                                MessageBox.Show("Message successfully sent!");
                                this.Hide();
                                Compose c = new Compose();
                                try { c.ShowDialog(); }
                                catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                                finally { this.Close(); }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Global.connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("saveMessage", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (subject != "")
                            cmd.Parameters.AddWithValue("@subject", subject);
                        if (message != "")
                            cmd.Parameters.AddWithValue("@text", message);
                        cmd.Parameters.AddWithValue("@senderuser", Global.loginUser);
                        cmd.Parameters.AddWithValue("@receiveruser", sendTo);
                        cmd.Parameters.AddWithValue("@attach1", bytes1);
                        cmd.Parameters.AddWithValue("@attach2", bytes2);
                        cmd.Parameters.AddWithValue("@attach3", bytes3);
                        if (des1 != "")
                            cmd.Parameters.AddWithValue("@des1", des1);
                        if (des2 != "")
                            cmd.Parameters.AddWithValue("@des2", des2);
                        if (des3 != "")
                            cmd.Parameters.AddWithValue("@des3", des3);
                        cmd.Parameters.AddWithValue("@filename1", filename1);
                        cmd.Parameters.AddWithValue("@filename2", filename2);
                        cmd.Parameters.AddWithValue("@filename3", filename3);
                        if (size1 != -1)
                            cmd.Parameters.AddWithValue("@size1", size1);
                        if (size2 != -1)
                            cmd.Parameters.AddWithValue("@size2", size2);
                        if (size3 != -1)
                            cmd.Parameters.AddWithValue("@size3", size3);
                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        conn.Close();
                        MessageBox.Show("Message successfully sent!");
                        this.Hide();
                        Compose c = new Compose();
                        try { c.ShowDialog(); }
                        catch (ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
                        finally { this.Close(); }
                    }
                }
            }
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
                              
    }
}
