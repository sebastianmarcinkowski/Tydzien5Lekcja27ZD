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

		public AddEditEmployee()
		{
			InitializeComponent();
			TabIndexOrder();

			MessageBox.Show("Trzeba dodać zamykanie okna po rozwiązaniu błędu z bazą danych i zapisie pracownika.");

			//pbEmployee.Image = Image.FromFile(Path.Combine(Program.ResourcesPath, $"SMKI.jpg"));
		}

		public void TabIndexOrder()
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

		private void pbEmployee_Click(object sender, EventArgs e)
		{
			if (pbEmployee.Image == null)
				MessageBox.Show("pictureBox jest pusty");

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
				List<Employee> employees = new List<Employee>();
				// W przypadku gdy plik z bazą istnieje ale nie posiada zapisanych pracowników funkcja JSON.FileHelper.DeserializeFromFile() chciała by zwrócić nulla, co spowodowało by rzucenie wyjątku przy zapytaniu LINQ w metodzie AssignIdToNewEmployee. Poniższy test wykrywa opisany błąd, użytkownik albo może usunąć bazę i stworzyć nową, albo zakończyć działanie programu i skontaktować się z pomocą techniczną.
				try
				{
					employees = data.DeserializeFromFile();
				}
				catch (Exception ex)
				{
					if (ex.Message == "DBIsDamaged")
					{
						var confirm = MessageBox.Show("Baza danych została uszkodzona, czy chciałbyś usunąć obecną bazę i utworzyć nową?",
						"Baza danych została uszkodzona",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Error);

						if (confirm == DialogResult.OK)
						{
							File.Delete(Program.DataPath);
							Directory.Delete(Program.ResourcesPath, true);
							Directory.CreateDirectory(Program.ResourcesPath);

							employees = data.DeserializeFromFile();
						}
						else
						{
							MessageBox.Show("Program zostanie zamknięty, skontaktuj się ze wsparciem technicznym.",
								"Baza danych została uszkodzona",
								MessageBoxButtons.OK,
								MessageBoxIcon.Asterisk);

							throw;
						}
					}
				}
				//DBIsDamagedExceptionTest(employeesList);
				AssignIdToNewEmployee(employees);


				AddEmployeeToList(employees);

				data.SerializeToFile(employees);
			}
		}

		private void DBIsDamagedExceptionTest(List<Employee> employees)
		// Do weryfikacji, nie działa poprawnie - zwraca pustą listę.
		{
			try
			{
				employees = data.DeserializeFromFile();
			}
			catch (Exception ex)
			{
				if (ex.Message == "DBIsDamaged")
				{
					var confirm = MessageBox.Show("Baza danych została uszkodzona, czy chciałbyś usunąć obecną bazę i utworzyć nową?",
					"Baza danych została uszkodzona",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Error);

					if (confirm == DialogResult.OK)
					{
						File.Delete(Program.DataPath);
						Directory.Delete(Program.ResourcesPath, true);
						Directory.CreateDirectory(Program.ResourcesPath);

						employees = data.DeserializeFromFile();
					}
					else
					{
						MessageBox.Show("Program zostanie zamknięty, skontaktuj się ze wsparciem technicznym.",
							"Baza danych została uszkodzona",
							MessageBoxButtons.OK,
							MessageBoxIcon.Asterisk);

						throw;
					}
				}
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
					DateOfEmployment = dtpDateOfEmployment.Value,
					DateOfDismissal = cbPerpetualContract.Checked ? dtpDateOfDismissal.MaxDate : dtpDateOfDismissal.Value,
					PerpetualContract = cbPerpetualContract.Checked,
					Salary = salary,
					Comments = rtbComments.Text
				};

				if (_employeeImage)
					pbEmployee.Image.Save(Path.Combine(Program.ResourcesPath, $"{_employeeId}.jpg"));

				employees.Add(employee);
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
