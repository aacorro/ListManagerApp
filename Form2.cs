using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListManagerApp
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			Form1 f1 = new Form1();
			f1.receiveData(textBox1.Text);

			// this refers to form 2
			this.Close();
		}
	}
}
