
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
			this.btFireTheEmployee = new System.Windows.Forms.Button();
			this.lbFilter = new System.Windows.Forms.Label();
			this.rbFilterAll = new System.Windows.Forms.RadioButton();
			this.rbFilterActive = new System.Windows.Forms.RadioButton();
			this.rbFilterFired = new System.Windows.Forms.RadioButton();
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
			// btFireTheEmployee
			// 
			this.btFireTheEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFireTheEmployee.Location = new System.Drawing.Point(161, 12);
			this.btFireTheEmployee.Name = "btFireTheEmployee";
			this.btFireTheEmployee.Size = new System.Drawing.Size(108, 23);
			this.btFireTheEmployee.TabIndex = 2;
			this.btFireTheEmployee.Text = "Zwolnij pracownika";
			this.btFireTheEmployee.UseVisualStyleBackColor = true;
			this.btFireTheEmployee.Click += new System.EventHandler(this.btFireTheEmployee_Click);
			// 
			// lbFilter
			// 
			this.lbFilter.AutoSize = true;
			this.lbFilter.Location = new System.Drawing.Point(522, 17);
			this.lbFilter.Name = "lbFilter";
			this.lbFilter.Size = new System.Drawing.Size(49, 13);
			this.lbFilter.TabIndex = 3;
			this.lbFilter.Text = "Wyświetl";
			// 
			// rbFilterAll
			// 
			this.rbFilterAll.AutoSize = true;
			this.rbFilterAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbFilterAll.Location = new System.Drawing.Point(577, 15);
			this.rbFilterAll.Name = "rbFilterAll";
			this.rbFilterAll.Size = new System.Drawing.Size(67, 17);
			this.rbFilterAll.TabIndex = 4;
			this.rbFilterAll.TabStop = true;
			this.rbFilterAll.Text = "Wszyscy";
			this.rbFilterAll.UseVisualStyleBackColor = true;
			this.rbFilterAll.Click += new System.EventHandler(this.rbFilterAll_Click);
			// 
			// rbFilterActive
			// 
			this.rbFilterActive.AutoSize = true;
			this.rbFilterActive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbFilterActive.Location = new System.Drawing.Point(650, 15);
			this.rbFilterActive.Name = "rbFilterActive";
			this.rbFilterActive.Size = new System.Drawing.Size(62, 17);
			this.rbFilterActive.TabIndex = 5;
			this.rbFilterActive.TabStop = true;
			this.rbFilterActive.Text = "Aktywni";
			this.rbFilterActive.UseVisualStyleBackColor = true;
			this.rbFilterActive.Click += new System.EventHandler(this.rbFilterActive_Click);
			// 
			// rbFilterFired
			// 
			this.rbFilterFired.AutoSize = true;
			this.rbFilterFired.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbFilterFired.Location = new System.Drawing.Point(718, 15);
			this.rbFilterFired.Name = "rbFilterFired";
			this.rbFilterFired.Size = new System.Drawing.Size(70, 17);
			this.rbFilterFired.TabIndex = 6;
			this.rbFilterFired.TabStop = true;
			this.rbFilterFired.Text = "Zwolnieni";
			this.rbFilterFired.UseVisualStyleBackColor = true;
			this.rbFilterFired.Click += new System.EventHandler(this.rbFilterFired_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rbFilterFired);
			this.Controls.Add(this.rbFilterActive);
			this.Controls.Add(this.rbFilterAll);
			this.Controls.Add(this.lbFilter);
			this.Controls.Add(this.btFireTheEmployee);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.btnAddNewEmployee);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Program kadrowy";
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddNewEmployee;
		private System.Windows.Forms.DataGridView dgvEmployees;
		private System.Windows.Forms.Button btFireTheEmployee;
		private System.Windows.Forms.Label lbFilter;
		private System.Windows.Forms.RadioButton rbFilterAll;
		private System.Windows.Forms.RadioButton rbFilterActive;
		private System.Windows.Forms.RadioButton rbFilterFired;
	}
}

