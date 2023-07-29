using ChallengeApp2;

namespace ChallengeApp2
{
    public class Employee
    {
        List<int> score = new List<int>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
       
        
        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {

            this.score.Add(number);
        }


        

    }
}