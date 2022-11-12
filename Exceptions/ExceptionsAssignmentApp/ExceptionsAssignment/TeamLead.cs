using ExceptionsAssignment.Contracts;

namespace ExceptionsAssignment
{
    public class TeamLead : EmployeeBase, IGiveAssignment
    {
        public void GiveAssignment(Assignment assignment, IGetAssignment employee)
        {
            employee.GetAssignment(assignment);
        }
    }
}
