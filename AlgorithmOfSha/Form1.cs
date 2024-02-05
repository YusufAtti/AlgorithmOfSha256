using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmOfSha
{
    public partial class Form1 : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-HP2NA5H\SQLEXPRESS;Initial Catalog=AlgoSha;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private string sha256BuildCode(string s)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
            var sb = new StringBuilder();
            for (int i=0; i<bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();

        }

        private void btnsign_Click(object sender, EventArgs e)
        {

            if (txtusename.Text.ToString().Length == 0
               || txtpass.Text.ToString().Length == 0)
            {
                MessageBox.Show(" Boxes cannot be left empty ");
                return;
            }

            string sorgu = "SELECT KullaniciAdi FROM Kullanici WHERE KullaniciAdi = @p1";

            try
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand(sorgu, connect);
                sqlCommand.Parameters.AddWithValue("@p1", txtusename.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                bool addnewuser = false;

                if (reader.HasRows)
                { // böyle bir kullanıcı varsa vtye ekleme yapılmaz
                    MessageBox.Show(txtusename.Text + "such a user is registered ");
                }
                else
                {
                    //veritabanına yeni kullanıcı ekleyebiliriz
                    addnewuser = true;
                    
                }
                reader.Close();
                if (addnewuser)
                {
                    sqlCommand = new SqlCommand("INSERT INTO Kullanici VALUES (@p1,@p2)", connect);
                    sqlCommand.Parameters.AddWithValue("@p1", txtusename.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", sha256BuildCode(txtpass.Text));
                    sqlCommand.ExecuteNonQuery();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Database Error !! " + " " + ex.Message);
            }

            finally
            {
                if (connect != null)
                    connect.Close();

            }

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if(txtusename.Text.ToString().Length == 0 
               || txtpass.Text.ToString().Length == 0)
            {
                MessageBox.Show(" Boxes cannot be left empty ");
                    return;
            }

            try
            {
                connect.Open();
                string query = "SELECT KullaniciAdi FROM Kullanici WHERE KullaniciAdi = @p1 " +
                    "AND Sifre = @p2";
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@p1", txtusename.Text);
                sqlCommand.Parameters.AddWithValue("@p2", sha256BuildCode(txtpass.Text));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                { // böyle bir kullanıcı varsa vtye ekleme yapılmaz
                    MessageBox.Show("Username and Password true WELCOME " + txtusename.Text);
                }
                else
                {
                    MessageBox.Show("Username or Password wrong ");
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Log In Error !! " + " " + ex.Message);
            }

            finally
            {
                if (connect != null)
                    connect.Close();

            }

        }
    }
}
