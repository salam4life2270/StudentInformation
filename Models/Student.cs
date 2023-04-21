using System;
using System.ComponentModel.DataAnnotations;

namespace StudentInformation.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }

		[Range(1, 7, ErrorMessage = "Module number must be between 1 and 7")]
		public int Module { get; set; }

        [Range(1, 10, ErrorMessage = "Grade must be between 1 and 10")]
        public int Grade { get; set; }
		

	}
}

