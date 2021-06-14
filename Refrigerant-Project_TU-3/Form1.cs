using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace Refrigerant_Project_TU_3
{
    public partial class Form1 : Form
    {
        public static int device;//използваме накрая да разберем какво устройство е избрал потребителя
        public static Boolean _isFridge = false;//проверяваме дали е хладилник или климатик
        public static int technician; //според дали е хладилник или климатик избираме майстора
        public static RichTextBox newbox = new RichTextBox();

        public Form1()
        {

            
            InitializeComponent();
            
            
        }


      

        private void Form1_Load(object sender, EventArgs e)
        {
          
           // air_con.Paint += new PaintEventHandler(this.drawlabel);
            //this.Controls.Add(air_con);
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
     

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_color_change(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.LightCoral;
            
        }
        private void exit_bttn_color_back(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.Transparent;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fridge_Click(object sender, EventArgs e)
        {
            _isFridge = true;
            problems_aircon login_form = new problems_aircon();
            login_form.Show();
            this.Hide();
        }

        private void exit_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fridge_btn_Click(object sender, EventArgs e)
        {
            fridge_types types = new fridge_types();
            types.Show();
            this.Hide();
        }

        private void aircon_btn_Click(object sender, EventArgs e)
        {
            device = 1; //потребителя е избрал климатик
            problems_aircon login_form = new problems_aircon();
            login_form.Show();
            this.Hide();
            technician = 2;
        }
    }
}
