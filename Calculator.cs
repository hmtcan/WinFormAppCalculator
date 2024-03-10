using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormAppCalculator
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		double value = 0; 
		string operation = ""; 
		bool operation_pressed = false; 

		private void button0_Click(object sender, EventArgs e)
		{

			if (txt_Result.Text == "0" || operation_pressed)
			{
				txt_Result.Clear();
			}

			

			Button button = sender as Button; 

			txt_Result.Text = txt_Result.Text + button.Text;
			operation_pressed = false; 

		}
		
		private void button3_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			operation = button.Text; 
			operation_pressed = true;
			value = double.Parse(txt_Result.Text);

		}

		private void btn_CE_Click(object sender, EventArgs e)
		{
			txt_Result.Clear();
		}

		private void btn_C_Click(object sender, EventArgs e)
		{
			txt_Result.Clear();
			value = 0;
		}

		private void btn_Equal_Click(object sender, EventArgs e)
		{
			
		}


	}
}
