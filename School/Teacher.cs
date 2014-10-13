using System;
using System.Collections.Generic;

namespace School
{
    public class Teacher : People
    {
        private IList<Discipline> disciplines;

        public Teacher (string name, IList<Discipline> disciplines, string details = null) : base(name, details)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(Discipline d)
        {
            this.disciplines.Add(d);
        }

        public override string ToString()
        {
            string result = "";
            if (this.Details != null)
            {
                result += this.Name + "\n";
                foreach (var d in disciplines)
                {
                    result += d + "\n";
                }
                result += this.Details + "\n";
            }
            else
            {
                result += this.Name + "\n";
                foreach (var d in disciplines)
                {
                    result += d + "\n";
                }
            }
            return result.ToString();
        } 
    }
}
