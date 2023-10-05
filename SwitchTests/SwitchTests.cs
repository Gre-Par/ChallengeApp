using ChallengeApp;

namespace SwitchTests
{
    public class Tests
    {
        [Test]
        public void AverageATest()
        {
            var employee = new Employee("Jula", "Nowak");
            employee.AddGrade(86);
            employee.AddGrade(90);
            employee.AddGrade('A');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(86, statistics.Min);
            Assert.AreEqual(92, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);
        }
        [Test]
        public void AverageCTest()
        {
            var employee = new Employee("Jula", "Nowak");
            employee.AddGrade(66);
            employee.AddGrade('c');
            employee.AddGrade(14);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(66, statistics.Max);
            Assert.AreEqual(14, statistics.Min);
            Assert.AreEqual(Math.Round(46.67, 2), Math.Round(statistics.Average, 2));
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}