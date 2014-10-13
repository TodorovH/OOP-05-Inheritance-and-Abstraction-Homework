using System;
using System.Collections.Generic;

namespace School
{
    public class Class : IDetails
    {
        private string uniqueTextId;
        private IList<Teacher> teachers;
        private IList<Student> classOfStudents;
        private string details;
        private static IList<string> uniqueIds;

        public string UniqueTextId
        { 
            get
            {
                return this.uniqueTextId;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The text identifier cannot be empty.");
                }
                this.uniqueTextId = value;
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

        public Class (string uniqueTextId, IList<Teacher> teachers, IList<Student> classOfStudents, string details = null)
        {
            this.UniqueTextId = uniqueTextId;
            this.teachers = teachers;
            this.classOfStudents = classOfStudents;
            this.Details = details;
        }

        public void AddStudentsInClass(Student s)
        {
            this.classOfStudents.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            this.teachers.Add(t);
        }

        public override string ToString()
        {
            string result = "";
            if (this.Details != null)
            {
                result += this.uniqueTextId + "\n";
                foreach (var t in teachers)
                {
                    result += t + "\n";
                }
                foreach (var s in classOfStudents)
                {
                    result += s + "\n";
                }
                result += this.Details + "\n";
            }
            else
            {
                result += this.uniqueTextId + "\n";
                foreach (var t in teachers)
                {
                    result += t + "\n";
                }
                foreach (var s in classOfStudents)
                {
                    result += s + "\n";
                }
            }
            return result.ToString();
        }
    }
}
