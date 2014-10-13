using System;
using System.Collections.Generic;

namespace School
{
    public class Discipline : IDetails
    {
        private string nameOfDiscipline;
        private int numberOfLectures;
        private IList<Student> students;
        private string details;

        public string NameOfDiscipline
        {
            get
            {
                return this.nameOfDiscipline;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of discipline cannot be empty.");
                }
                this.nameOfDiscipline = value;
            }
        }

        public int NumberOfLectures
        { 
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures cannot be negative.");
                }
                this.numberOfLectures = value;
            }
        }

        public string Details 
        { 
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }


        public Discipline (string nameOfDiscipline, int numberOfLectures, IList<Student> students, string details = null)
        {
            this.NameOfDiscipline = nameOfDiscipline;
            this.NumberOfLectures = numberOfLectures;
            this.students = students;
            this.Details = details;
        }

        public void AddStudent(Student s)
        {
            this.students.Add(s);
        }

        public override string ToString()
        {
            string result = "";
            result += this.NameOfDiscipline + " " + this.NumberOfLectures + "\n";
            foreach (var s in students)
            {
                result += s + "\n";
            }
            return result.ToString();
        }
    }
}
