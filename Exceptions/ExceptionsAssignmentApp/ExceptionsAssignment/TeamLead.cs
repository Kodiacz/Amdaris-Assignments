using ExceptionsAssignment.Contracts;

namespace ExceptionsAssignment
{
    public class TeamLead : EmployeeBase, IGiveAssignment
    {
        public TeamLead(string firstName, string lastName, string phonenumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phonenumber = phonenumber;
        }

        public void GiveAssignment(Assignment assignment, IGetAssignment employee)
        {
            employee.GetAssignment(assignment);
        }
    }
}
