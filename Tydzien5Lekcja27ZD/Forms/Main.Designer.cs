
namespace Tydzien5Lekcja27ZD
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btnAddNewEmployee = new System.Windows.Forms.Button();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddNewEmployee
			// 
			this.btnAddNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddNewEmployee.Location = new System.Drawing.Point(12, 12);
			this.btnAddNewEmployee.Name = "btnAddNewEmployee";
			this.btnAddNewEmployee.Size = new System.Drawing.Size(142, 23);
			this.btnAddNewEmployee.TabIndex = 0;
			this.btnAddNewEmployee.Text = "Dodaj nowego pracownika";
			this.btnAddNewEmployee.UseVisualStyleBackColor = true;
			this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
			this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployees.GridColor = System.Drawing.Color.White;
			this.dgvEmployees.Location = new System.Drawing.Point(12, 41);
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.ReadOnly = true;
			this.dgvEmployees.RowHeadersVisible = false;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(776, 397);
			this.dgvEmployees.TabIndex = 1;
			this.dgvEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellDoubleClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.btnAddNewEmployee);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Program kadrowy";
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddNewEmployee;
		private System.Windows.Forms.DataGridView dgvEmployees;
	}
}

