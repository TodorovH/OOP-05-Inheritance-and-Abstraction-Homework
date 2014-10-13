using System;

namespace School
{
    public abstract class People : IDetails
    {
        private string name;
        private string details;

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                this.name = value;
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

        public People (string name)
        {
            this.Name = name;
        }

        public People (string name, string details = null) : this(name)
        {
            this.Details = details;
        }

        public override string ToString()
        {
            string result = "";
            if (this.Details != null)
            {
                result += this.Name + this.Details;
            } 
            else
            {
                result += this.Name;
            }
            return result;
        }
    }
}
