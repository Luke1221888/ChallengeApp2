namespace ChallengeApp2
{
    public class Employee
    {
        List<int> positiveScore = new List<int>();
        List<int> negativeScore = new List<int>();

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
                var sumPositiveScore = this.positiveScore.Sum();
                var sumNegativeScore = this.negativeScore.Sum();
                var result = sumPositiveScore + sumNegativeScore;
                return result;
            }
        }
        public void AddScore(int score)
        {
            if (score >= 0)
            {
                this.positiveScore.Add(score);
            }
            else
            {
                this.negativeScore.Add(score);
            }
        }
    }
}