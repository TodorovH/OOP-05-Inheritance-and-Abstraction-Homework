using System;
using System.Collections.Generic;

namespace School
{
    public class Student : People
    {
        private int uniqueClassNumber;
        private static IList<int> uniqueClassNumbers = new List<int>();

        public int UniqueClassNumber 
        { 
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The class number cannot be negative.");
                }
                if (uniqueClassNumbers.Contains(value))
                {
                    throw new ArgumentException("The class number is not unique.");
                }
                this.uniqueClassNumber = value;
            }
        }
        
        public Student (string name, int uniqueClassNumber) : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            Student.uniqueClassNumbers.Add(uniqueClassNumber);
        }

        public Student(string name, int uniqueClassNumber, string details = null) : base(name, details) { }

        public override string ToString()
        {
            string result = "";
            if (this.Details != null)
            {
                result += this.Name + ", N " + this.UniqueClassNumber + this.Details; 
            }
            else
            {
                result += this.Name + ", N " + this.UniqueClassNumber;
            }
            return result.ToString();
        }
    }
}
