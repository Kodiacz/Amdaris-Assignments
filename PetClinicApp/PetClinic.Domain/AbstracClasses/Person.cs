﻿namespace PetClinic.Domain.AbstracClasses
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Phonenumber { get; set; }
    }
}
