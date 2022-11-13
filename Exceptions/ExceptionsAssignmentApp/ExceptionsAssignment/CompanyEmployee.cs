using ExceptionsAssignment.Contracts;

namespace ExceptionsAssignment
{
    public class CompanyEmployee : EmployeeBase, IGetAssignment, IAbleForMore
    {
        private const int AssignmentsCapacity = 5;

        public CompanyEmployee(string firstName, string lastName, string phonenumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phonenumber = phonenumber;
        }

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public bool IsAbleForMoreAssignments => this.Assignments.Count >= AssignmentsCapacity;

        public void GetAssignment(Assignment assignment)
        {
            this.Assignments.Add(assignment);
        }
    }
}
