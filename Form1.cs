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
	public partial class Form1 : Form
	{
		// list to hold all of the names
		static List<string> names = new List<string>();
		BindingSource namesBindingSource = new BindingSource();


		public Form1()
		{
			InitializeComponent();


			//testing names
			//names.Add("Addam");
			//names.Add("Beth");
			//names.Add("Chris");
		}

		internal void receiveData(string newName)
		{
			names.Add(newName);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// form 1 opens form 2 when add button is clicked
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// add the names to the listbox


			// set the data source for the binding
			namesBindingSource.DataSource = names;

			// set the binding to the list
			listBox1.DataSource = namesBindingSource;

		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			// occurs whenever the form regains focus and comes back to the foreground.
			namesBindingSource.ResetBindings(false);
		}

		private void listBox1_Click(object sender, EventArgs e)
		{
			
			int i = listBox1.SelectedIndex;
			if(i >= 0)
			{
				DialogResult result =  MessageBox.Show("Would you like to delete " + names[i] + '?', "Confirm Delete", MessageBoxButtons.YesNo);

				if (result == DialogResult.Yes)
				{
					names.RemoveAt(i);
					namesBindingSource.ResetBindings(false);
				}

				
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == "A --> Z")
			{
				names.Sort();
			}
			else
			{
				names.Sort();
				names.Reverse();
			}
			namesBindingSource.ResetBindings(false);
		}
	}
}
