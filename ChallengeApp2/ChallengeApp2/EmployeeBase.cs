
namespace ChallengeApp2
{
    public abstract class EmployeeBase : IEmployee
    {

        public EmployeeBase(string name, string surname, int age, string sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public string Sex { get; private set; }



        public abstract void AddGrade(uint grade);


        public abstract void AddGrade(int grade);



        public abstract void AddGrade(long grade);



        public abstract void AddGrade(float grade);




        public abstract void AddGrade(string grade);


        public abstract void AddGrade(char grade);


        public abstract void AddGrade(double grade);


        public abstract Statistics GetStatistics();
        
    }
}
