namespace ChallengeApp2
{
    public interface IEmployee
    {
            
        string Name { get; }

        string Surname { get; }

        int Age { get; }

        string Sex { get; }

        
        void AddGrade(uint grade);

        void AddGrade(int grade);

        void AddGrade(long grade);

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        void AddGrade(double grade);


        Statistics GetStatistics();
    }
}
