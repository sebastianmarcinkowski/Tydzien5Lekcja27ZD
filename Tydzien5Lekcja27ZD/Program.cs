﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Tydzien5Lekcja27ZD
{
	static class Program
	{
		public static string DataPath = Path.Combine(
			Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
			"data.json");

		public static string ResourcesPath = Path.Combine(
			Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
			"Resources");

		public static List<string> ResourceTrash;

		public static string ResourceTrashPath = Path.Combine(
			Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
			"resource-trash.json");

		[STAThread]
		static void Main()
		{
			try
			{
				JSONFileHelper<List<string>> resourceTrash = new JSONFileHelper<List<string>>(ResourceTrashPath);

				ResourceTrash = resourceTrash.DeserializeFromFile();

				foreach (var image in ResourceTrash)
				{
					if (File.Exists(Path.Combine(Program.ResourcesPath, $"{image}.jpg")))
						File.Delete(Path.Combine(Program.ResourcesPath, $"{image}.jpg"));
				}

				ResourceTrash = new List<string>();

				if (!Directory.Exists(ResourcesPath))
					Directory.CreateDirectory(ResourcesPath);

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Main());

				resourceTrash.SerializeToFile(ResourceTrash);
			}
			catch (Exception)
			{
				MessageBox.Show("Wystąpił błąd programu, aplikacja zostanie zamknięta, skontaktuj się ze wsparciem technicznym!",
					"Błąd krytyczny",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

		}
	}
}
