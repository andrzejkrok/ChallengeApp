﻿namespace ChallengeApp
{
    public abstract class Person : System.Object
    {
        public Person()
        { 
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }


        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
    }
}
