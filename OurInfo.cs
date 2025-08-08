using System;

namespace Final_Luke_Jacob.Models
{


	public class OurInfo
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string CollegeProgram { get; set; } = string.Empty;
        public string YearinProgram { get; set; } = string.Empty;
    }
}