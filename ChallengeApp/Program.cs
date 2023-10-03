using ChallengeApp;

var employee = new Employee("Jula", "Nowak");
employee.AddGrade(2);
employee.AddGrade("Kasia");
employee.AddGrade(407);
employee.AddGrade(5.89);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Get Statistics With For Each: Average = {statistics1.Average:N2} , Min = {statistics1.Min} , MAx = {statistics1.Max}");

Console.WriteLine($"Get Statistics With For: Average = {statistics2.Average:N2} , Min = {statistics2.Min} , Max = {statistics2.Max}");

Console.WriteLine($"Get Statistics With Do While: Average = {statistics3.Average:N2} , Min = {statistics3.Min} , Max = {statistics3.Max}");

Console.WriteLine($"Get Statistics With While: Average = {statistics4.Average:N2} , Min = {statistics4.Min} , Max = {statistics4.Max}");