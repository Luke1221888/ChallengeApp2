namespace ChallengeApp2.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoPositiveScores_ShouldReturnCorrectResult()
        {
            // arrange
            var employee4 = new Employee("Robert", "Dadacki", 50);
            employee4.AddScore(1);
            employee4.AddScore(3);
            // act
            var result = employee4.Result;
            // assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void IfEmployeeCollectTwoNegativeScores_ShouldReturnCorrectResult()
        {
            var employee5 = new Employee("Bogdan", "Eecki", 42);
            employee5.AddScore(-60);
            employee5.AddScore(-50);
            
            var result = employee5.Result;
            
            Assert.AreEqual(-110, result);
        }
        [Test]
        public void IfEmployeeCollectNegativeAndPositiveScore_ShouldReturnCorrectResult()
        {
            var employee6 = new Employee("Cezary", "Zetowski", 18);
            employee6.AddScore(-10);
            employee6.AddScore(5);
            
            var result = employee6.Result;
            
            Assert.AreEqual(-5, result);
        }
    }
}