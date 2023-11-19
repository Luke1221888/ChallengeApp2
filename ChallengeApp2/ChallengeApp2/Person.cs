using System;


namespace ChallengeApp2
{
    public abstract class Person : System.Object
    {

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public string Sex { get; private set; }


        public Person(string name, string surname, int age, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
