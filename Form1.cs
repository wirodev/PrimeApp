using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrimeApp
{
	public partial class Form1 : Form
	{
		private string userName;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			userName = txtName.Text;
			lblGreeting.Text = $"Hello, {userName}!";
		}

		private void btnGenerateList_Click(object sender, EventArgs e)
		{
			int number;
			if (int.TryParse(txtNumber.Text, out number))
			{
				List<int> numbers = GenerateNumbers(number);
				DisplayNumbers(numbers);
			}
			else
			{
				MessageBox.Show("Please enter a valid number.");
			}
		}

		private List<int> GenerateNumbers(int max)
		{
			List<int> numbers = new List<int>();
			for (int i = 1; i <= max; i++)
			{
				numbers.Add(i);
			}
			return numbers;
		}

		private void DisplayNumbers(List<int> numbers)
		{
			lstNumbers.Items.Clear();
			foreach (var number in numbers)
			{
				bool isPrime = IsPrime(number);
				var listItem = isPrime ? $"{number} (Prime)" : number.ToString();
				lstNumbers.Items.Add(listItem);
			}
		}

		private bool IsPrime(int number)
		{
			if (number < 2) return false;
			for (int i = 2; i <= Math.Sqrt(number); i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
