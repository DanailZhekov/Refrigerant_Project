using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerant_Project_TU_3
{
    public partial class нев : Form
    {
       

        public нев()
        {
            InitializeComponent();
        }

        public void getProblem(string problem)
        {
            Form1.newbox.Text = problem;

        }
        private Boolean checkForUser()
        {
            Console.WriteLine("checking for users: ");
            User check = login_form.sendUser();
            if (String.IsNullOrEmpty(check.getName())) return false;
            return true;
        }
        public void gotoFinal()
        {
            final final = new final(); ;
            final.Show();
            this.Hide();
        }
        private void goToSignUp()
        {
            signUp final = new signUp(); ;
            final.Show();
            this.Hide();
        }


        private void нев_Load(object sender, EventArgs e)
        {

        }

        private void problem6_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(problem6.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(problem6.Text);
                this.goToSignUp();
            }
        }

        private void problem1_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(problem1.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(problem1.Text);
                this.goToSignUp();
            }
        }

        private void problem2_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(problem2.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(problem2.Text);
                this.goToSignUp();
            }
        }

        private void problem3_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(problem3.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(problem3.Text);
                this.goToSignUp();
            }
        }

        private void problem4_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(problem4.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(problem4.Text);
                this.goToSignUp();
            }
        }

        private void problem5_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(problem5.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(problem5.Text);
                this.goToSignUp();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkForUser())
            {
                this.getProblem(button8.Text);
                this.gotoFinal();
            }
            else
            {
                this.getProblem(button8.Text);
                this.goToSignUp();
            }
        }

        private void exit_btn_color(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.LightCoral;

        }
        private void exit_bttn_color(object sender, EventArgs e)
        {
            exit_login.BackColor = Color.Transparent;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

            Form1 begin = new Form1();
            begin.Show();
            this.Hide();
        }

        private void exit_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
