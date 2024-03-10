using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Amaç: 4 işlem hesap makinesi
// Kazanım & Kapsam: Bool operation ile rakam girişi veya sayıların işleme tabi tutulup, tutulmadığını mantıksal olarak kavrama
//   Tek bir buton click event'i ile rakam yazdırma, işlem operatörlerini işlevsel hale getirme
//   Tip dönüştürme ve Convert etme (String-Int)


namespace WinFormAppCalculator
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		double value = 0; // Sonuçları tutsun
		string operation = ""; // +, -, *, / İşaretini tutsun
		bool operation_pressed = false; // False = işlem operatör butonlarına basılmamış, yani rakam girişi yapılmaya devam ediyor  
										//bool operation_pressed = true; // true = rakam butonuna basılmamış, işlem operatörleriyle işlem yapılıyor. 

		//Rakam butonlarına basıldığında;
		private void button0_Click(object sender, EventArgs e)
		{

			if (txt_Result.Text == "0" || operation_pressed)
			{
				txt_Result.Clear();
			}

			// Cast(ing) = tip dönüştürme
			// ConvertToInt32(txt_sonuc) 

			Button button = sender as Button; // ConvertToButton(sender) // 1. yol
											  //Button button = (Button)sender; // 2. yol

			txt_Result.Text = txt_Result.Text + button.Text;
			operation_pressed = false; // Rakam butonuna basıldığı için

		}
		// İşlem operatör butonlarına basıldığında;
		private void button3_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			operation = button.Text; // İşlem operatör işaretlerini bu değişkene atadım
			operation_pressed = true; // İşlem operatör butonlarına basılıyor
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
			switch (operation)
			{
				case "+":
					txt_Result.Text = (value + double.Parse(txt_Result.Text)).ToString();
					break;

				case "-":
					txt_Result.Text = (value - double.Parse(txt_Result.Text)).ToString();
					break;

				case "x":
					txt_Result.Text = (value * double.Parse(txt_Result.Text)).ToString();
					break;

				case "/":
					txt_Result.Text = (value / double.Parse(txt_Result.Text)).ToString();
					break;

				default:
					break;
			}
		}


	}
}
