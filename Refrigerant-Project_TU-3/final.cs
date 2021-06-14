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
    public partial class final : Form
    {
        OracleConnection connection = new OracleConnection("");
        private User final_user = login_form.sendUser();
        private Boolean fridge = Form1._isFridge;
        private int type = fridge_types.type;
        private int tech_id = Form1.technician;
        private string new_phone,new_address;

        public final()
        {
            
            InitializeComponent();
            this.setConnection();
        }

        public void radioButtonChecked() // проверява кои са натиснатите радио бутони
        {
            if (notphone_rad.Checked) new_phone = another_phone.Text;
            else new_phone = myphone.Text;

            if (notaddress_rad.Checked) new_address = another_address.Text;
            else new_address = myaddress.Text;
        }


        private void setConnection()// връзва базата с visual studio, чете connection string от config файла
        {


            String connectionString = ConfigurationManager.ConnectionStrings["TSPproject"].ConnectionString;
            connection = new OracleConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

      
        private void final_Load(object sender, EventArgs e)
        {
            phone_rad.Checked = true;
            address_rad.Checked = true;

            richTextBox1.Text = Form1.newbox.Text;

            myaddress.Text = final_user.getAddress();
            myphone.Text = final_user.getPhone();



/*            OracleCommand comand = connection.CreateCommand();

            comand.CommandText = "SELECT problem FROM reservasion WHERE id_res = 7";
            comand.CommandType = CommandType.Text;

            OracleDataReader dr = comand.ExecuteReader();
                    dr.Read();


                    if (dr.HasRows)
                    {
                        Form1.newbox.Text = dr.GetString(0);
                    }

            */
            

            

            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            

           /*Console.WriteLine(problems_fridge.problem_string);    
           if(fridge)
            if (type == 1)
                label1.Text = problems_fridge.problem_string;
            else if (type == 2)
                label1.Text = instalations.problem_string;
            else
                label1.Text = нев.problem_string;

            else
                label1.Text = problems_aircon.problem_string;
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "мога ли да пиша на кирилица ве???";
        }
        private void exit_btn_color(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.LightCoral;

        }
        private void exit_bttn_color(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.Transparent;

        }
        private void exit_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Form1.device)
            {
                case 1:
                    {
                        problems_aircon aircon = new problems_aircon();
                        aircon.Show();
                        this.Hide();
                        break;
                    }
                case 2:
                    {
                        instalations instalation = new instalations();
                        instalation.Show();
                        this.Hide();
                        break;
                    }
                case 3:
                    {
                        problems_fridge home = new problems_fridge();
                        home.Show();
                        this.Hide();
                        break;
                    }
                default:
                    {
                        нев build = new нев();
                        build.Show();
                        this.Hide();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e) //записва резервацията в базата взимайки данните чрез клас User.
        {
            this.radioButtonChecked();

            OracleCommand comand = connection.CreateCommand();

            comand.CommandText = "INSERT INTO RESERVASION(reservation_date, technicians_id_tech, users_id, problem, phone, address) VALUES(TO_DATE('" + this.dateTimePicker1.Text + "','yyyy-mm-dd'), :technicians_id_tech, :user_id, :problem, :phone, :address)";
            comand.CommandType = CommandType.Text;


            //comand.Parameters.Add("date", OracleDbType.Date).Value = this.dateTimePicker1.Text;
            comand.Parameters.Add("technicians_id_tech", OracleDbType.Varchar2, 50).Value = tech_id;
            comand.Parameters.Add("user_id", OracleDbType.Varchar2, 30).Value = final_user.getId();
            comand.Parameters.Add("problem", OracleDbType.Varchar2, 1000).Value = richTextBox1.Text;
            comand.Parameters.Add("phone", OracleDbType.Varchar2, 30).Value = new_phone;
            comand.Parameters.Add("address", OracleDbType.Varchar2, 30).Value = new_address;


            comand.ExecuteNonQuery();

            MessageBox.Show("Благодарим ви че избрахте нас, нашите техници ще се свържат с вас сутринта в посочения ден!");
            Application.Exit();
            connection.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login_form.clearUser();
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
            connection.Close();
        }
    }
}
