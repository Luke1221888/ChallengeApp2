﻿namespace ChallengeApp2
{
    public class Employee : IEmployee
    {

        private List<float> grades = new List<float>();



        public Employee(string name, string surname, int age, string sex)

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


        public void AddGrade(uint grade)
        {
            {
                float gradeAsFloat = (float)grade;
                AddGrade(gradeAsFloat);
            }
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charGrade))
            {
                AddGrade(charGrade);
            }
            else
            {
                throw new Exception($"Podano nazwę nie będącą ani literą ani liczbą");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Niewłaściwa litera");

            }
        }

        public void AddGrade(long grade)
        {
            {
                float gradeAsFloat = (float)grade;
                AddGrade(gradeAsFloat);
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
                throw new Exception("Dodano za małą bądź za dużą liczbę");
            }
        }

        public void AddGrade(double grade)
        {

            {
                float gradeAsFloat = (float)grade;
                AddGrade(gradeAsFloat);
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}