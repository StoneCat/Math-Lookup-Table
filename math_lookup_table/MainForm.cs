/*
 * Created by SharpDevelop.
 * User: StoneCat
 * Date: 16.09.2016
 * Time: 23:11
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace math_lookup_table
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Math_Lookup_Table : Form
	{
		private int i_value_x = 1;
		private int i_value_b = 1;
		
		public Math_Lookup_Table()
		{
			InitializeComponent();
			// Default is + in DropDownMenu
			this.dropdown_plus_minus.SelectedIndex = 0;
			// Check if input like + or - || Easy Switch between + and - over Numpad when dropdown is selected
			this.dropdown_plus_minus.TextChanged += dropdown_plus_minus_TextChanged;
			// Check if input numeric and save it
			this.txtb_value_x.TextChanged += txtb_value_x_TextChanged;
			// Check if input numeric and save it
			this.txtb_value_b.TextChanged += txtb_value_b_TextChanged;
			// Add automatic data generator after insert -> no button needed
			this.txtb_value_x.TextChanged += generateData;
			this.txtb_value_b.TextChanged += generateData;
			this.dropdown_plus_minus.TextChanged += generateData;
			this.dropdown_plus_minus.SelectedIndexChanged += generateData;
		}

		void dropdown_plus_minus_TextChanged(object sender, EventArgs e)
		{
			if (this.dropdown_plus_minus.Text == "+")
				this.dropdown_plus_minus.SelectedIndex = 0;
			else if (this.dropdown_plus_minus.Text == "-" || this.dropdown_plus_minus.Text == "-+")
				this.dropdown_plus_minus.SelectedIndex = 1;
			else
				this.dropdown_plus_minus.SelectedIndex = 0;
		}

		void txtb_value_x_TextChanged(object sender, EventArgs e)
		{
			int i;
			if (!int.TryParse(this.txtb_value_x.Text, out i))
				this.txtb_value_x.Text = "";
			else
				this.i_value_x = i;
		}

		void txtb_value_b_TextChanged(object sender, EventArgs e)
		{
			int i;
			if (!int.TryParse(this.txtb_value_b.Text, out i))
				this.txtb_value_b.Text = "";
			else
				this.i_value_b = i;
		}
		
		private bool checkifallfilled()
		{
			if (this.txtb_value_x.Text != "" && 
			    this.txtb_value_b.Text != "")
				return true;
			else
				return false;
		}

		void generateData(object sender, EventArgs e)
		{
			if (this.checkifallfilled())
			{
				this.dataGridView.Rows.Clear();
				
				if (this.dropdown_plus_minus.Text == "+")
				{
					for (int i = 1; i != 10; i++)
						this.dataGridView.Rows.Add(i, Calc.calculate_data_f_x_with_plus(this.i_value_x, i, this.i_value_b));
				}
				else
				{	
					for (int i = 1; i != 10; i++)
						this.dataGridView.Rows.Add(i, Calc.calculate_data_f_x_with_minus(this.i_value_x, i, this.i_value_b));
				}
			}
		}
	}
}
