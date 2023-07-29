using System;

namespace Tydzien5Lekcja27ZD.Models
{
	class Employee
	{
		public int Id { get; set; }
		public string Status { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool Image { get; set; }
		public DateTime DateOfEmployment { get; set; }
		public DateTime DateOfDismissal { get; set; }
		public bool PerpetualContract { get; set; }
		public decimal Salary { get; set; }
		public string Comments { get; set; }
	}
}
