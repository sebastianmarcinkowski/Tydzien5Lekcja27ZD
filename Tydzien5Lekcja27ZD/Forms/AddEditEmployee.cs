using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tydzien5Lekcja27ZD.Models;

namespace Tydzien5Lekcja27ZD.Forms
{
	public partial class AddEditEmployee : Form
	{
		private JSONFileHelper<List<Employee>> data = new JSONFileHelper<List<Employee>>(Program.DataPath);

		private int _employeeId;
		private bool _setImage = false;
		private string _employeeStatus = "active";

		private Employee _employee;

		public AddEditEmployee(int id = 0)
		{
			InitializeComponent();
			_employeeId = id;

			TabIndexOrder();
			GetEmployeeData();
		}

		private void TabIndexOrder()
		{
			tbFirstName.TabIndex = 0;
			tbLastName.TabIndex = 1;
			tbSalary.TabIndex = 2;
			dtpDateOfEmployment.TabIndex = 3;
			cbPerpetualContract.TabIndex = 4;
			dtpDateOfDismissal.TabIndex = 5;
			rtbComments.TabIndex = 6;
			btnAddEditEmployee.TabIndex = 7;
		}

		private void GetEmployeeData()
		{
			if (_employeeId != 0)
			{
				Text = "Edytowanie danych pracownika";
				tbId.Select(); // By imię nie podświetlało się.

				btnAddEditEmployee.Text = "Zapisz zmiany";

				var employees = data.DeserializeFromFile();
				_employee = employees.FirstOrDefault(x => x.Id == _employeeId);

				if (_employee == null)
					throw new Exception("EmployeeIdEditError");

				FillEmployee();
			}
		}

		private void FillEmployee()
		{
			if (_employee.Image != Guid.Parse("00000000-0000-0000-0000-000000000000"))
			{
				if (File.Exists(Path.Combine(Program.ResourcesPath, $"{_employee.Image}.jpg")))
				{
					pbEmployee.Image = Image.FromFile(Path.Combine(Program.ResourcesPath, $"{_employee.Image}.jpg"));
					_setImage = true;
				}
				else
					_employee.Image = Guid.Parse("00000000-0000-0000-0000-000000000000");
			}

			tbId.Text = _employee.Id.ToString();
			tbFirstName.Text = _employee.FirstName;
			tbLastName.Text = _employee.LastName;
			tbSalary.Text = _employee.Salary.ToString();

			switch (_employee.Status)
			{
				case "active":
					lbStatusState.Text = "Aktywny";
					break;
				case "fired":
					lbStatusState.Text = "Zwolniony";
					lbStatusState.ForeColor = Color.Red;
					break;
				default:
					throw new Exception("EmployeeStatusLoadError");
			}

			dtpDateOfEmployment.Value = _employee.DateOfEmployment;
			cbPerpetualContract.Checked = _employee.PerpetualContract;
			dtpDateOfDismissal.Value = _employee.DateOfDismissal;

			rtbComments.Text = _employee.Comments;

			if (_employee.Status == "fired")
			{
				pbEmployee.Enabled = false;
				tbFirstName.Enabled = false;
				tbLastName.Enabled = false;
				tbSalary.Enabled = false;
				dtpDateOfEmployment.Enabled = false;
				cbPerpetualContract.Enabled = false;
				dtpDateOfDismissal.Enabled = false;

				_employeeStatus = "fired";
			}
		}

		private void pbEmployee_Click(object sender, EventArgs e)
		{
			using (var openFD = new OpenFileDialog())
			{
				openFD.Filter = "Pliki obrazów (*.jpg, *.jpeg, *.gif) | *.jpg; *.jpeg; *.gif";
				if (openFD.ShowDialog() == DialogResult.OK)
				{
					pbEmployee.Image = new Bitmap(openFD.FileName);
				}

				_setImage = true;
			}
		}

		private void btnAddEditEmployee_Click(object sender, EventArgs e)
		{
			if (IsFormFilled())
			{
				var employees = data.DeserializeFromFile();

				if (_employeeId != 0)
				{
					var employee = employees.Where(x => x.Id == _employeeId).FirstOrDefault();

					if (employee.Image != Guid.Parse("00000000-0000-0000-0000-000000000000"))
						Program.ResourceTrash.Add(employee.Image.ToString());

					employees.RemoveAll(x => x.Id == _employeeId);
				}
				else
					AssignIdToNewEmployee(employees);

				AddEmployeeToList(employees);
			}
		}

		private void AssignIdToNewEmployee(List<Employee> employees)
		{
			var employeeWithHighestId = employees
				.OrderByDescending(x => x.Id)
				.FirstOrDefault();

			_employeeId = employeeWithHighestId == null ?
				1 : employeeWithHighestId.Id + 1;
		}

		private void AddEmployeeToList(List<Employee> employees)
		{
			if (!decimal.TryParse(tbSalary.Text, out decimal salary))
			{
				throw new Exception("AddEmployeeSalaryError");
			}
			else
			{
				var employee = new Employee
				{
					Id = _employeeId,
					Status = _employeeStatus,
					FirstName = tbFirstName.Text,
					LastName = tbLastName.Text,
					DateOfEmployment = dtpDateOfEmployment.Value.Date,
					DateOfDismissal = cbPerpetualContract.Checked ? dtpDateOfDismissal.Value.Date.AddYears(100) : dtpDateOfDismissal.Value.Date,
					PerpetualContract = cbPerpetualContract.Checked,
					Salary = salary,
					Comments = rtbComments.Text
				};

				if (_setImage)
				{
					employee.Image = Guid.NewGuid();
					pbEmployee.Image.Save(Path.Combine(Program.ResourcesPath, $"{employee.Image}.jpg"));
				}

				employees.Add(employee);

				data.SerializeToFile(employees);

				Close();
			}
		}

		private bool IsFormFilled()
		{
			var result = true;
			var mboxText = "Aby dodać pracownika należy uzupełnić:";

			if (tbFirstName.Text == "")
			{
				mboxText += "\n- Imię";
				result = false;
			}

			if (tbLastName.Text == "")
			{
				mboxText += ",\n- Nazwisko";
				result = false;
			}

			if (tbSalary.Text == "")
			{
				mboxText += ",\n- Wynagrodzenie";
				result = false;
			}

			if (!result)
				MessageBox.Show(mboxText, "Nie wszystkie wymagane pola są uzupełnione", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

			if (!decimal.TryParse(tbSalary.Text, out decimal tempSalary))
			{
				MessageBox.Show("Podaj poprawną wartość wynagrodzenia!");
				result = false;
			}

			return result;
		}

		private void cbPerpetualContract_CheckedChanged(object sender, EventArgs e)
		{
			if (cbPerpetualContract.Checked)
			{
				dtpDateOfDismissal.Enabled = false;
			}
			else
			{
				dtpDateOfDismissal.Enabled = true;
			}
		}
	}
}
