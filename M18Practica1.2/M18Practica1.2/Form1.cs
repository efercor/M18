using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M18Practica1._2
{
	
    public partial class Form1 : Form
    {
		Form2 ventanaPaciente;
		
		public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			ventanaPaciente = new Form2();
			ventanaPaciente.ShowDialog();
		}
	}
}
