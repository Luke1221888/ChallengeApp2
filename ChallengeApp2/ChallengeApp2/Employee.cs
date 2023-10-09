﻿namespace ChallengeApp2
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void AddGrade(uint grade)
        {
            uint valueInUint = (uint)grade;
            float floatValue = (float)valueInUint;
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(floatValue);
            }
            else
            {
                Console.WriteLine($"{grade} is invalid score added");
            }
        }
        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine($"{grade} is invalid score added");
            }
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"{grade} is invalid score added");
            }
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine($"{grade} is invalid score added");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"String {grade} is not number");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}


