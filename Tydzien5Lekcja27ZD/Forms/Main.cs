using System;
using System.Collections.Generic;
using System.Linq;
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
			TabIndexOrder();
		}

		private void RefreshDGV(string filter = "active")
		{
			var employees = data.DeserializeFromFile();

			switch (filter)
			{
				case "all":
					dgvEmployees.DataSource = employees;
					rbFilterAll.Checked = true;
					break;
				case "active":
					dgvEmployees.DataSource = employees.Where(x => x.Status == "active").ToList();
					rbFilterActive.Checked = true;
					break;
				case "fired":
					dgvEmployees.DataSource = employees.Where(x => x.Status == "fired").ToList();
					rbFilterFired.Checked = true;
					break;
				default:
					throw new Exception("FilterModeError");
			}
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

		private void TabIndexOrder()
		{
			btnAddNewEmployee.TabIndex = 0;
			btFireTheEmployee.TabIndex = 1;
			rbFilterAll.TabIndex = 2;
			rbFilterActive.TabIndex = 3;
			rbFilterFired.TabIndex = 4;
		}

		private void btnAddNewEmployee_Click(object sender, System.EventArgs e)
		{
			var addEditEmployee = new AddEditEmployee();

			addEditEmployee.FormClosing += AddEditEmployee_FormClosing;

			addEditEmployee.ShowDialog();

			addEditEmployee.FormClosing -= AddEditEmployee_FormClosing;
		}

		private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
		{
			RefreshDGV();
		}

		private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value));

			addEditEmployee.FormClosing += AddEditEmployee_FormClosing;

			addEditEmployee.ShowDialog();

			addEditEmployee.FormClosing -= AddEditEmployee_FormClosing;
		}

		private void btFireTheEmployee_Click(object sender, EventArgs e)
		{
			if (dgvEmployees.SelectedRows.Count == 0)
			{
				MessageBox.Show("Proszę zaznacz pracownika, którego chcesz zwolnić.",
					"Nie wybrałeś pracownika!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Asterisk);
				return;
			}

			var selectedEmployee = dgvEmployees.SelectedRows[0];

			if (selectedEmployee.Cells[1].Value.ToString() == "fired")
			{
				MessageBox.Show("Zaznaczony pracownik jest już zwolniony.",
					"Pracownik jest już zwolniony!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				var mboxEmployee =
					(selectedEmployee.Cells[2].Value.ToString() + " " +
					selectedEmployee.Cells[3].Value.ToString()).Trim();

				var confirmDelete =
					MessageBox.Show($"Czy na pewno chcesz zwolnić pracownika {mboxEmployee}?",
					"Zwalnianie pracownika",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question);

				if (confirmDelete == DialogResult.OK)
				{
					FireTheEmployee(Convert.ToInt32(selectedEmployee.Cells[0].Value));
					RefreshDGV();
				}
			}
		}

		private void FireTheEmployee(int id)
		{
			var employees = data.DeserializeFromFile();
			var employee = employees.Where(x => x.Id == id).FirstOrDefault();

			employee.Status = "fired";
			employee.DateOfDismissal = DateTime.Now.Date;

			data.SerializeToFile(employees);
		}

		private void rbFilterAll_Click(object sender, EventArgs e)
		{
			RefreshDGV("all");
		}

		private void rbFilterActive_Click(object sender, EventArgs e)
		{
			RefreshDGV();
		}

		private void rbFilterFired_Click(object sender, EventArgs e)
		{
			RefreshDGV("fired");
		}
	}
}
