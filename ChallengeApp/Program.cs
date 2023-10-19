using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników, ocena kierownika");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Greta", "Pardyka") ;
//employee.AddGrade(0.5f);
//employee.AddGrade(20);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Ocena: {statistics.AverageLetter}");