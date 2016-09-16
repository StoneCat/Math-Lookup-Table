/*
 * Created by SharpDevelop.
 * User: Garfield
 * Date: 16.09.2016
 * Time: 23:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace math_lookup_table
{
	partial class Math_Lookup_Table
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_InfoText_Input;
		private System.Windows.Forms.Label lbl_f_of_x;
		private System.Windows.Forms.TextBox txtb_value_x;
		private System.Windows.Forms.Label lbl_x;
		private System.Windows.Forms.ComboBox dropdown_plus_minus;
		private System.Windows.Forms.TextBox txtb_value_b;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn column_x;
		private System.Windows.Forms.DataGridViewTextBoxColumn column_fx;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_InfoText_Input = new System.Windows.Forms.Label();
			this.lbl_f_of_x = new System.Windows.Forms.Label();
			this.txtb_value_x = new System.Windows.Forms.TextBox();
			this.lbl_x = new System.Windows.Forms.Label();
			this.dropdown_plus_minus = new System.Windows.Forms.ComboBox();
			this.txtb_value_b = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.column_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.column_fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_InfoText_Input
			// 
			this.lbl_InfoText_Input.Location = new System.Drawing.Point(13, 9);
			this.lbl_InfoText_Input.Name = "lbl_InfoText_Input";
			this.lbl_InfoText_Input.Size = new System.Drawing.Size(160, 16);
			this.lbl_InfoText_Input.TabIndex = 0;
			this.lbl_InfoText_Input.Text = "Please insert your numbers here";
			// 
			// lbl_f_of_x
			// 
			this.lbl_f_of_x.Location = new System.Drawing.Point(13, 39);
			this.lbl_f_of_x.Name = "lbl_f_of_x";
			this.lbl_f_of_x.Size = new System.Drawing.Size(33, 15);
			this.lbl_f_of_x.TabIndex = 1;
			this.lbl_f_of_x.Text = "f(x) =";
			// 
			// txtb_value_x
			// 
			this.txtb_value_x.Location = new System.Drawing.Point(49, 37);
			this.txtb_value_x.Name = "txtb_value_x";
			this.txtb_value_x.Size = new System.Drawing.Size(28, 20);
			this.txtb_value_x.TabIndex = 2;
			// 
			// lbl_x
			// 
			this.lbl_x.Location = new System.Drawing.Point(83, 39);
			this.lbl_x.Name = "lbl_x";
			this.lbl_x.Size = new System.Drawing.Size(12, 18);
			this.lbl_x.TabIndex = 3;
			this.lbl_x.Text = "X";
			// 
			// dropdown_plus_minus
			// 
			this.dropdown_plus_minus.FormattingEnabled = true;
			this.dropdown_plus_minus.Items.AddRange(new object[] {
			"+",
			"-"});
			this.dropdown_plus_minus.Location = new System.Drawing.Point(101, 36);
			this.dropdown_plus_minus.Name = "dropdown_plus_minus";
			this.dropdown_plus_minus.Size = new System.Drawing.Size(29, 21);
			this.dropdown_plus_minus.TabIndex = 4;
			// 
			// txtb_value_b
			// 
			this.txtb_value_b.Location = new System.Drawing.Point(136, 37);
			this.txtb_value_b.Name = "txtb_value_b";
			this.txtb_value_b.Size = new System.Drawing.Size(28, 20);
			this.txtb_value_b.TabIndex = 5;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.column_x,
			this.column_fx});
			this.dataGridView.Location = new System.Drawing.Point(12, 63);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView.Size = new System.Drawing.Size(150, 187);
			this.dataGridView.TabIndex = 6;
			// 
			// column_x
			// 
			this.column_x.FillWeight = 1F;
			this.column_x.HeaderText = "x";
			this.column_x.MaxInputLength = 100;
			this.column_x.MinimumWidth = 55;
			this.column_x.Name = "column_x";
			this.column_x.ReadOnly = true;
			this.column_x.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.column_x.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.column_x.Width = 55;
			// 
			// column_fx
			// 
			this.column_fx.HeaderText = "f(x)";
			this.column_fx.MinimumWidth = 55;
			this.column_fx.Name = "column_fx";
			this.column_fx.ReadOnly = true;
			this.column_fx.Width = 55;
			// 
			// Math_Lookup_Table
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 262);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.txtb_value_b);
			this.Controls.Add(this.dropdown_plus_minus);
			this.Controls.Add(this.lbl_x);
			this.Controls.Add(this.txtb_value_x);
			this.Controls.Add(this.lbl_f_of_x);
			this.Controls.Add(this.lbl_InfoText_Input);
			this.Name = "Math_Lookup_Table";
			this.Text = "math_lookup_table";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
