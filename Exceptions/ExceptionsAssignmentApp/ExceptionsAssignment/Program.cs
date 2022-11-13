using ExceptionsAssignment;
using ExceptionsAssignment.Exceptions;

Company company = new Company();

try
{
    TeamLead teamLead = new TeamLead("Marin", "Donev", "359895665432");
    CompanyEmployee companyEmployee = new CompanyEmployee("Dragomir", "Andreev", "0895443776");
    Assignment assignment = new Assignment("Work on bug");
    company.AddAssignment(teamLead, companyEmployee, assignment);
}
catch (WrongPhonenumberException ex)
{
    Console.WriteLine(ex.Message);
}
catch (WrongNameException ex)
{
    Console.WriteLine(ex.Message);
}
catch (TooManyAssignmentsException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
