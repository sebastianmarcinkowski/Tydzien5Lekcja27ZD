using System;
using System.IO;
using System.Windows.Forms;
using Tydzien5Lekcja27ZD.Forms;

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

		[STAThread]
		static void Main()
		{
			if (!Directory.Exists(ResourcesPath))
				Directory.CreateDirectory(ResourcesPath);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AddEditEmployee());

		}
	}
}
