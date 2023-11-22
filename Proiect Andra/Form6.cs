using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Andra
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton2.Checked && radioButton6.Checked && radioButton7.Checked)
				MessageBox.Show("FELICITARI!");
			else
				MessageBox.Show("MAI INCEARCA!");
		}

		
	
	}
}
