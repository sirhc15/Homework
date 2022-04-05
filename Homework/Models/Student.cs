using System;

namespace Homework.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int SchoolCode { get; set; }

        //properties to keep existing app working
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public Student()
        { 
        }

        public Student(
            int studentId,
            string lastName,
            string firstName,
            string address,
            string city,
            string state,
            int zipCode,
            int schoolCode
            )
        {
            StudentId = studentId;
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            SchoolCode = schoolCode;
        }
    }
}
