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
    public partial class fridge_types : Form
    {
        public static int type; //определяме типа на хладилник с който потребителя има проблем(хладилна инсталация, домашен хладилник, има нужда от изграждане)

        public fridge_types()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.device = 3; // домашен хладилник
            Form1.technician = 1;
            type = 1;
            problems_fridge domashen = new problems_fridge();
            domashen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.device = 2; // хладилна инсталация
            Form1.technician = 1;
            type = 2;
            instalations inst = new instalations();
            inst.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.device = 4; // изграждане
            Form1.technician = 3;
            type = 3;
            нев nov = new нев();
            nov.Show();
            this.Hide();
        }
    }
}
