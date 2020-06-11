using System;

namespace CSharpLanguageTester
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Person(string fname, string lname, string cityName)
        {
            FirstName = fname;
            LastName = lname;
            City = cityName;
        }

        // Return the first and last name.
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

    }
}
