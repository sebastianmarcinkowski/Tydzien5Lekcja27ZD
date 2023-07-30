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
		private bool _employeeImage = false;

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
			if(_employeeId != 0)
			{
				Text = "Edytowanie danych pracownika";
				tbId.Select(); // By imię nie podświetlało się.

				var employees = data.DeserializeFromFile();
				_employee = employees.FirstOrDefault(x => x.Id == _employeeId);

				if (_employee == null)
					throw new Exception("EmployeeIdEditError");

				FillEmployee();
			}
		}

		private void FillEmployee()
		{
			if (_employee.Image)
				pbEmployee.Image = Image.FromFile(Path.Combine(Program.ResourcesPath, $"{_employee.Id}.jpg"));

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
			dtpDateOfDismissal.Value = _employee.DateOfDismissal;
		}

		private void pbEmployee_Click(object sender, EventArgs e)
		{
			var openFD = new OpenFileDialog();
			openFD.Filter = "Pliki obrazów (*.jpg, *.jpeg, *.gif) | *.jpg; *.jpeg; *.gif";
			if (openFD.ShowDialog() == DialogResult.OK)
			{
				pbEmployee.Image = new Bitmap(openFD.FileName);
			}

			_employeeImage = true;
		}

		private void btnAddEditEmployee_Click(object sender, EventArgs e)
		{
			if (IsFormFilled())
			{
				List<Employee> employees = data.DeserializeFromFile();
				AssignIdToNewEmployee(employees);
				AddEmployeeToList(employees);
				data.SerializeToFile(employees);
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
			if (!int.TryParse(tbSalary.Text, out int salary))
			{
				MessageBox.Show("Podaj poprawną wartość wynagrodzenia!");
			}
			else
			{
				var employee = new Employee
				{
					Id = _employeeId,
					Status = "active",
					FirstName = tbFirstName.Text,
					LastName = tbLastName.Text,
					Image = _employeeImage,
					DateOfEmployment = dtpDateOfEmployment.Value.Date,
					DateOfDismissal = cbPerpetualContract.Checked ? dtpDateOfDismissal.Value.Date.AddYears(100) : dtpDateOfDismissal.Value.Date,
					PerpetualContract = cbPerpetualContract.Checked,
					Salary = salary,
					Comments = rtbComments.Text
				};

				if (_employeeImage)
					pbEmployee.Image.Save(Path.Combine(Program.ResourcesPath, $"{_employeeId}.jpg"));

				employees.Add(employee);

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
