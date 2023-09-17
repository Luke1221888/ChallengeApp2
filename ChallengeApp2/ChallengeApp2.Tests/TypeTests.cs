namespace ChallengeApp2.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckIfNamesAreEqual()
        {
            var employee1 = GetEmployee("Łukasz");
            var employee2 = GetEmployee("Łukasz");

          Assert.AreEqual(employee2.Name, employee1.Name);
        }
        [Test]
        public void CheckIfIntValuesAreNotEqual()
        {
            int number1 = 5;
            int number2 = 10;

            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void CheckIfFloatValuesAreEqual()
        {
            float number1 = 2000000000000;
            float number2 = 2000000000000;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void CheckIfTwoStringsAreEqual()
        {
            string myName1 = "Samochód";
            string myName2 = "Samochód";

            Assert.AreEqual(myName1, myName2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
