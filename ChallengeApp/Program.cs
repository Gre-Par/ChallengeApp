using ChallengeApp;

var employee = new Employee("Jula", "Nowak");
employee.AddGrade(2);
employee.AddGrade(7);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
// Console.WriteLine("Average: " + statistics.Max);
