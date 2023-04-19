using System;
using System.ComponentModel.DataAnnotations;

namespace StudentInformation.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string? Name { get; set; }

		[Range(1, 8, ErrorMessage = "Module number must be between 1 and 8")]
		public int Module { get; set; }

        [Range(1, 10, ErrorMessage = "Grade must be between 1 and 8")]
        public int Grade { get; set; }
		

	}
}

