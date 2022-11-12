using ExceptionsAssignment.Contracts;

namespace ExceptionsAssignment
{
    public class CompanyEmployee : EmployeeBase, IGetAssignment
    {
        private const int AssignmentsCapacity = 5;

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public bool IsAbleForMoreAssignments => this.Assignments.Count < AssignmentsCapacity;

        public void GetAssignment(Assignment assignment)
        {
            this.Assignments.Add(assignment);
        }
    }
}
