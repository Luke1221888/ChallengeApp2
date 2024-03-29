﻿
namespace ChallengeApp2
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname, int age, string sex)
            : base(name, surname, age, sex)
        {

        }

        public override void AddGrade(uint grade)
        {
            float gradeAsFloat = grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {

            float gradeAsFloat = grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);


                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception($"Wprowadzono niewłaściwą liczbę");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
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

        public override void AddGrade(char grade)
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

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = ReadGradesFromFile();
            var result = CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {

            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
        
            return statistics;
        }
    }
}
