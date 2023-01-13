using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_19
{
    class Person 
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public string SSN { get; } = "";
        public Person(string fName, string lName, int personaAge, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            Age = personaAge;
            SSN = ssn;
        }
        //возвратть хэш код на основе уникальных строковых данных
        public override int GetHashCode() => SSN.GetHashCode();
        public Person() { }
    }
}
