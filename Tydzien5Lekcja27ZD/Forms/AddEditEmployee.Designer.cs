
namespace Tydzien5Lekcja27ZD.Forms
{
	partial class AddEditEmployee
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
			this.pbEmployee = new System.Windows.Forms.PictureBox();
			this.btnAddEditEmployee = new System.Windows.Forms.Button();
			this.lbFirstName = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.lbId = new System.Windows.Forms.Label();
			this.lbDateOfEmployment = new System.Windows.Forms.Label();
			this.lbSalary = new System.Windows.Forms.Label();
			this.lbLastName = new System.Windows.Forms.Label();
			this.lbDateOfDismissal = new System.Windows.Forms.Label();
			this.lbComments = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.dtpDateOfEmployment = new System.Windows.Forms.DateTimePicker();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbSalary = new System.Windows.Forms.TextBox();
			this.dtpDateOfDismissal = new System.Windows.Forms.DateTimePicker();
			this.rtbComments = new System.Windows.Forms.RichTextBox();
			this.cbPerpetualContract = new System.Windows.Forms.CheckBox();
			this.lbStatus = new System.Windows.Forms.Label();
			this.lbStatusState = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// pbEmployee
			// 
			this.pbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbEmployee.Image = global::Tydzien5Lekcja27ZD.Properties.Resources.defaultEmployeeAvatar;
			this.pbEmployee.Location = new System.Drawing.Point(30, 22);
			this.pbEmployee.Name = "pbEmployee";
			this.pbEmployee.Size = new System.Drawing.Size(100, 100);
			this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbEmployee.TabIndex = 0;
			this.pbEmployee.TabStop = false;
			this.pbEmployee.Click += new System.EventHandler(this.pbEmployee_Click);
			// 
			// btnAddEditEmployee
			// 
			this.btnAddEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddEditEmployee.ForeColor = System.Drawing.Color.Black;
			this.btnAddEditEmployee.Location = new System.Drawing.Point(112, 433);
			this.btnAddEditEmployee.Name = "btnAddEditEmployee";
			this.btnAddEditEmployee.Size = new System.Drawing.Size(104, 23);
			this.btnAddEditEmployee.TabIndex = 1;
			this.btnAddEditEmployee.Text = "Dodaj pracownika";
			this.btnAddEditEmployee.UseVisualStyleBackColor = true;
			this.btnAddEditEmployee.Click += new System.EventHandler(this.btnAddEditEmployee_Click);
			// 
			// lbFirstName
			// 
			this.lbFirstName.AutoSize = true;
			this.lbFirstName.ForeColor = System.Drawing.Color.Black;
			this.lbFirstName.Location = new System.Drawing.Point(152, 51);
			this.lbFirstName.Name = "lbFirstName";
			this.lbFirstName.Size = new System.Drawing.Size(26, 13);
			this.lbFirstName.TabIndex = 2;
			this.lbFirstName.Text = "Imię";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(211, 48);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(95, 20);
			this.tbFirstName.TabIndex = 3;
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.ForeColor = System.Drawing.Color.Black;
			this.lbId.Location = new System.Drawing.Point(152, 25);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(96, 13);
			this.lbId.TabIndex = 4;
			this.lbId.Text = "Numer pracownika";
			// 
			// lbDateOfEmployment
			// 
			this.lbDateOfEmployment.AutoSize = true;
			this.lbDateOfEmployment.ForeColor = System.Drawing.Color.Black;
			this.lbDateOfEmployment.Location = new System.Drawing.Point(27, 184);
			this.lbDateOfEmployment.Name = "lbDateOfEmployment";
			this.lbDateOfEmployment.Size = new System.Drawing.Size(90, 13);
			this.lbDateOfEmployment.TabIndex = 5;
			this.lbDateOfEmployment.Text = "Data zatrudnienia";
			// 
			// lbSalary
			// 
			this.lbSalary.AutoSize = true;
			this.lbSalary.ForeColor = System.Drawing.Color.Black;
			this.lbSalary.Location = new System.Drawing.Point(152, 103);
			this.lbSalary.Name = "lbSalary";
			this.lbSalary.Size = new System.Drawing.Size(81, 13);
			this.lbSalary.TabIndex = 6;
			this.lbSalary.Text = "Wynagrodzenie";
			// 
			// lbLastName
			// 
			this.lbLastName.AutoSize = true;
			this.lbLastName.ForeColor = System.Drawing.Color.Black;
			this.lbLastName.Location = new System.Drawing.Point(152, 77);
			this.lbLastName.Name = "lbLastName";
			this.lbLastName.Size = new System.Drawing.Size(53, 13);
			this.lbLastName.TabIndex = 7;
			this.lbLastName.Text = "Nazwisko";
			// 
			// lbDateOfDismissal
			// 
			this.lbDateOfDismissal.AutoSize = true;
			this.lbDateOfDismissal.ForeColor = System.Drawing.Color.Black;
			this.lbDateOfDismissal.Location = new System.Drawing.Point(27, 253);
			this.lbDateOfDismissal.Name = "lbDateOfDismissal";
			this.lbDateOfDismissal.Size = new System.Drawing.Size(82, 13);
			this.lbDateOfDismissal.TabIndex = 8;
			this.lbDateOfDismissal.Text = "Data zwolnienia";
			// 
			// lbComments
			// 
			this.lbComments.AutoSize = true;
			this.lbComments.ForeColor = System.Drawing.Color.Black;
			this.lbComments.Location = new System.Drawing.Point(27, 305);
			this.lbComments.Name = "lbComments";
			this.lbComments.Size = new System.Drawing.Size(37, 13);
			this.lbComments.TabIndex = 9;
			this.lbComments.Text = "Uwagi";
			// 
			// tbId
			// 
			this.tbId.Cursor = System.Windows.Forms.Cursors.No;
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(263, 22);
			this.tbId.MaximumSize = new System.Drawing.Size(43, 20);
			this.tbId.MinimumSize = new System.Drawing.Size(43, 20);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(43, 20);
			this.tbId.TabIndex = 10;
			// 
			// dtpDateOfEmployment
			// 
			this.dtpDateOfEmployment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtpDateOfEmployment.Location = new System.Drawing.Point(30, 200);
			this.dtpDateOfEmployment.Name = "dtpDateOfEmployment";
			this.dtpDateOfEmployment.Size = new System.Drawing.Size(276, 20);
			this.dtpDateOfEmployment.TabIndex = 12;
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(211, 74);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(95, 20);
			this.tbLastName.TabIndex = 11;
			// 
			// tbSalary
			// 
			this.tbSalary.Location = new System.Drawing.Point(239, 100);
			this.tbSalary.Name = "tbSalary";
			this.tbSalary.Size = new System.Drawing.Size(67, 20);
			this.tbSalary.TabIndex = 13;
			// 
			// dtpDateOfDismissal
			// 
			this.dtpDateOfDismissal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtpDateOfDismissal.Location = new System.Drawing.Point(30, 269);
			this.dtpDateOfDismissal.Name = "dtpDateOfDismissal";
			this.dtpDateOfDismissal.Size = new System.Drawing.Size(276, 20);
			this.dtpDateOfDismissal.TabIndex = 14;
			// 
			// rtbComments
			// 
			this.rtbComments.Location = new System.Drawing.Point(30, 321);
			this.rtbComments.Name = "rtbComments";
			this.rtbComments.Size = new System.Drawing.Size(276, 96);
			this.rtbComments.TabIndex = 15;
			this.rtbComments.Text = "";
			// 
			// cbPerpetualContract
			// 
			this.cbPerpetualContract.AutoSize = true;
			this.cbPerpetualContract.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbPerpetualContract.Location = new System.Drawing.Point(30, 233);
			this.cbPerpetualContract.Name = "cbPerpetualContract";
			this.cbPerpetualContract.Size = new System.Drawing.Size(184, 17);
			this.cbPerpetualContract.TabIndex = 16;
			this.cbPerpetualContract.Text = "Zatrudniony na czas nieokreślony";
			this.cbPerpetualContract.UseVisualStyleBackColor = true;
			this.cbPerpetualContract.CheckedChanged += new System.EventHandler(this.cbPerpetualContract_CheckedChanged);
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.lbStatus.Location = new System.Drawing.Point(39, 140);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(79, 25);
			this.lbStatus.TabIndex = 17;
			this.lbStatus.Text = "Status";
			// 
			// lbStatusState
			// 
			this.lbStatusState.AutoSize = true;
			this.lbStatusState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStatusState.ForeColor = System.Drawing.Color.Green;
			this.lbStatusState.Location = new System.Drawing.Point(124, 140);
			this.lbStatusState.Name = "lbStatusState";
			this.lbStatusState.Size = new System.Drawing.Size(182, 25);
			this.lbStatusState.TabIndex = 18;
			this.lbStatusState.Text = "Nowy pracownik";
			// 
			// AddEditEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(338, 479);
			this.Controls.Add(this.lbStatusState);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.cbPerpetualContract);
			this.Controls.Add(this.rtbComments);
			this.Controls.Add(this.dtpDateOfDismissal);
			this.Controls.Add(this.tbSalary);
			this.Controls.Add(this.dtpDateOfEmployment);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.lbComments);
			this.Controls.Add(this.lbDateOfDismissal);
			this.Controls.Add(this.lbLastName);
			this.Controls.Add(this.lbSalary);
			this.Controls.Add(this.lbDateOfEmployment);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.lbFirstName);
			this.Controls.Add(this.btnAddEditEmployee);
			this.Controls.Add(this.pbEmployee);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "AddEditEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dodawanie nowego pracownika";
			((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbEmployee;
		private System.Windows.Forms.Button btnAddEditEmployee;
		private System.Windows.Forms.Label lbFirstName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbDateOfEmployment;
		private System.Windows.Forms.Label lbSalary;
		private System.Windows.Forms.Label lbLastName;
		private System.Windows.Forms.Label lbDateOfDismissal;
		private System.Windows.Forms.Label lbComments;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.DateTimePicker dtpDateOfEmployment;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbSalary;
		private System.Windows.Forms.DateTimePicker dtpDateOfDismissal;
		private System.Windows.Forms.RichTextBox rtbComments;
		private System.Windows.Forms.CheckBox cbPerpetualContract;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.Label lbStatusState;
	}
}