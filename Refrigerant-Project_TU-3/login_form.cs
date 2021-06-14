using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Refrigerant_Project_TU_3
{
    public partial class login_form : Form
    {
        private static User user = new User();
        OracleConnection conn = new OracleConnection("");

        public login_form()
        {
            
            InitializeComponent();
            this.setConnection();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = user_email_tx;
            user_email_tx.Focus();
        }

        public static void clearUser(){
            user = new User();
            user.print();
        }
        public static User sendUser() {
            user.print();
            return user;
        }
       /* private void login()
        {

            try
            {
                if (String.IsNullOrWhiteSpace(user_email_tx.Text) || String.IsNullOrWhiteSpace(password_tx.Text))
                {
                    MessageBox.Show("Enter E-mail and password");
                 
                }

                OracleCommand comand = conn.CreateCommand();
                comand.CommandText = "SELECT name, address, email, phone FROM users where email=:user_email AND password=:user_password";
                comand.CommandType = CommandType.Text;

                comand.Parameters.Add("user_email", OracleDbType.Varchar2, 30).Value = user_email_tx.Text.Trim();
                comand.Parameters.Add("user_password", OracleDbType.Varchar2, 50).Value = password_tx.Text.Trim();

                OracleDataReader dr = comand.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    
                    user.setName(dr.GetString(0));
                    user.setAddress(dr.GetString(1));
                    user.setEmail(dr.GetString(2));
                    user.setPhone(dr.GetString(3));
                    user.print();

                    //MessageBox.Show("hello!");
                    //Console.WriteLine(dr.GetString(0));
                }
                else MessageBox.Show("Грешен е-майл или парола!");


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }*/
        private void setConnection() // връзва базата с visual studio, чете connection string от config файла
        {


            String connectionString = ConfigurationManager.ConnectionStrings["TSPproject"].ConnectionString;
            conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            signUp signup_form = new signUp();
            signup_form.Show();
            this.Hide();
            conn.Close();
        }

        private void login_bt_Click(object sender, EventArgs e) // бутон за вход в системата 
        {



            try
            {

                if (String.IsNullOrWhiteSpace(user_email_tx.Text) || String.IsNullOrWhiteSpace(password_tx.Text)) // проверка за празни текстови полета
                {
                    MessageBox.Show("Моля въведете емайл и парола!");

                }
                else
                {
                    OracleCommand comand = conn.CreateCommand();
                    comand.CommandText = "SELECT id,name, address, email, phone FROM users where email=:user_email AND password=:user_password";
                    comand.CommandType = CommandType.Text;

                    comand.Parameters.Add("user_email", OracleDbType.Varchar2, 30).Value = user_email_tx.Text.Trim();
                    comand.Parameters.Add("user_password", OracleDbType.Varchar2, 50).Value = password_tx.Text.Trim();

                    OracleDataReader dr = comand.ExecuteReader();
                    dr.Read();


                    if (dr.HasRows) // записва данните в обект от класа User 
                    {
                        user.setId(dr.GetInt32(0));
                        user.setName(dr.GetString(1));
                        user.setAddress(dr.GetString(2));
                        user.setEmail(dr.GetString(3));
                        user.setPhone(dr.GetString(4));
                       
                        final finalF = new final();
                        finalF.Show();
                        this.Hide();

                        //MessageBox.Show("hello!");
                        //Console.WriteLine(dr.GetString(0));
                    }
                    else
                    {
                        MessageBox.Show("Грешен е-майл или парола!");
                        password_tx.Text = "";
                       
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_btn_color(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.LightCoral;

        }
        private void exit_bttn_color(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.Transparent;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
    }
}
