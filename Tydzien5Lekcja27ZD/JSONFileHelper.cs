using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Tydzien5Lekcja27ZD
{
	public class JSONFileHelper<T> where T : new()
	{
		private string _filePath;

		public JSONFileHelper(string filePath)
		{
			_filePath = filePath;
		}

		public void SerializeToFile(T obj)
		{
			var json = JsonConvert.SerializeObject(obj);

			File.WriteAllText(_filePath, json);
		}

		public T DeserializeFromFile()
		{
			if (!File.Exists(_filePath))
			{
				return new T();
			}

			var json = File.ReadAllText(_filePath);

			if (JsonConvert.DeserializeObject<T>(json) == null)
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

					return new T();
				}
				else
				{
					MessageBox.Show("Program zostanie zamknięty, skontaktuj się ze wsparciem technicznym.",
						"Baza danych została uszkodzona",
						MessageBoxButtons.OK,
						MessageBoxIcon.Asterisk);

					throw new Exception("DBIsDamaged");
				}
			}

			return JsonConvert.DeserializeObject<T>(json);
		}
	}
}
