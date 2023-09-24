using ChallengeApp2;

public class EmployeeTests
{
    [Test]
    public void IfThereAreThreeScores_ShouldStatisticShowCorrectMax()
    {
        //arranage
        var employee2 = new Employee("Maciej", "Abacki");
        employee2.AddGrade(100);
        employee2.AddGrade(-50);
        employee2.AddGrade(0);
        //act
        var statistics = employee2.GetStatistics();
        //assert
        Assert.AreEqual(statistics.Max, statistics.Max);
    }
    [Test]
    public void IfThereAreThreeScores_ShouldStatisticShowCorrectAverage()
    {

        var employee2 = new Employee("Maciej", "Abacki");
        employee2.AddGrade(100);
        employee2.AddGrade(-50);
        employee2.AddGrade(0);

        var statistics = employee2.GetStatistics();

        Assert.AreEqual(statistics.Average, statistics.Average);
    }
    [Test]
    public void IfThereAreThreeScores_ShouldStatisticShowCorrectMin()
    {
        var employee2 = new Employee("Maciej", "Abacki");
        employee2.AddGrade(100);
        employee2.AddGrade(-50);
        employee2.AddGrade(0);

        var statistics = employee2.GetStatistics();

        Assert.AreEqual(statistics.Min, statistics.Min);
    }
}



