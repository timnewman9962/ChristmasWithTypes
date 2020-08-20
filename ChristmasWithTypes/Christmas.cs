using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        //public int TreeHeight { get; set; } //TODO Make the Height property nullable
        public int? TreeHeight { get; set; }

        //TODO Make the property, "Day", type enum
        //public enum Day { /*Fill out the days of the week*/ };
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    }
}
