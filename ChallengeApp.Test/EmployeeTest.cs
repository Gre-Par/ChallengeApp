namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMaxGrade()
        {
            // arrange
            var employee = new Employee("Jula", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(9);
            employee.AddGrade(4);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void CheckMinGrade()
        {
            var employee = new Employee("Jula", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(9);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void CheckIfAverageIsCorrect()
        {
            var employee = new Employee("Jula", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(9);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Average);
        }
    }
}