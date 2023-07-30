using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tydzien5Lekcja27ZD.Forms;
using Tydzien5Lekcja27ZD.Models;

namespace Tydzien5Lekcja27ZD
{
	public partial class Main : Form
	{
		private JSONFileHelper<List<Employee>> data = new JSONFileHelper<List<Employee>>(Program.DataPath);

		public Main()
		{
			InitializeComponent();
			RefreshDGV();
			SetColumnHeader();
		}

		private void RefreshDGV()
		{
			var employees = data.DeserializeFromFile();
			dgvEmployees.DataSource = employees;
		}

		private void SetColumnHeader()
		{
			dgvEmployees.Columns[nameof(Employee.Id)].HeaderText = "Nr pracownika";
			dgvEmployees.Columns[nameof(Employee.Status)].Visible = false;
			dgvEmployees.Columns[nameof(Employee.FirstName)].HeaderText = "Imię";
			dgvEmployees.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
			dgvEmployees.Columns[nameof(Employee.Image)].Visible = false;
			dgvEmployees.Columns[nameof(Employee.DateOfEmployment)].Visible = false;
			dgvEmployees.Columns[nameof(Employee.DateOfDismissal)].Visible = false;
			dgvEmployees.Columns[nameof(Employee.PerpetualContract)].Visible = false;
			dgvEmployees.Columns[nameof(Employee.Salary)].HeaderText = "Wynagrodzenie";
			dgvEmployees.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";
		}

		private void btnAddNewEmployee_Click(object sender, System.EventArgs e)
		{
			var addEditEmployee = new AddEditEmployee();

			addEditEmployee.ShowDialog();
		}

		private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value));

			addEditEmployee.ShowDialog();
		}
	}
}
