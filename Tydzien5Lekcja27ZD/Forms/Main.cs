using System.Collections.Generic;
using System.Windows.Forms;
using Tydzien5Lekcja27ZD.Models;

namespace Tydzien5Lekcja27ZD
{
	public partial class Main : Form
	{
		private JSONFileHelper<List<Employee>> data = new JSONFileHelper<List<Employee>>(Program.DataPath);

		public Main()
		{
			InitializeComponent();
		}
	}
}
