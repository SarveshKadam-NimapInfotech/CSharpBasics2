using System;

namespace Properties
{
    internal partial class Program
    {
        public class person
        {
            public string  Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthdate { get; private set; }

            public person(DateTime birthdate)
            {
                this.Birthdate = birthdate;
            }

            public int Age
            {
                get
                {
                    var timeSpan = DateTime.Today - Birthdate;
                    var years = timeSpan.Days/365;

                    return years;
                }
            }
        }
    }
}
