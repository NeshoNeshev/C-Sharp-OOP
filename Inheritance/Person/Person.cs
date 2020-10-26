using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        private int age;

        public virtual int Age
        {
            get 
            {
                return this.age;
            }
            protected set
            {
                if (age >= 0)
                {
                    this.age = value;
                }

            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}",
                         this.Name,
                         this.Age));

            return sb.ToString();
        }

    }
}
