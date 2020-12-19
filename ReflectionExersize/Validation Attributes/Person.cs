
using ValidationAttributes;

namespace CommandPattern
{
    public class Person
    {
        public Person(string fullName,int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequired]
        //[Required]
        public string FullName { get;private set; }
        [MyRangeAttribute(12, 90)]
        //[Range(12,90)]
        public int Age { get;private set; }
    }
}
