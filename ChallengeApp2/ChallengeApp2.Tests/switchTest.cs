namespace ChallengeApp2.Tests
{
    public class SwitchTest
    {
        
        [Test]

        public void WhenEmployeeGetGradeAboveEighty_ShouldReturnCorrectAverageLetter()
        {

            //arrange czyli przygotowanie
            var employee = new Employee();
            employee.AddGrade(100);

            //                                              
            //act czyli uruchomienie
            Statistics result = employee.GetStatistics();
            var average = result.Average;

            //assert czyli sprawdzenie
            Assert.AreEqual('A', result.AverageLetter);
            
        }
        [Test]

        public void WhenEmplyeeGetGradeAboveSixty_ShouldReturnCorrectAverageLetter()
        {

            var employee = new Employee();
            employee.AddGrade(63);

            Statistics result = employee.GetStatistics();

            Assert.AreEqual('B', result.AverageLetter);
        }
        [Test]

        public void WhenEmployeeGetsGradeAboveForty_ShouldReturnCorrectAverageLetter()
        {
            var employee = new Employee();
            employee.AddGrade(48);

            Statistics result = employee.GetStatistics();

            Assert.AreEqual('C', result.AverageLetter);
        }
    }
}
