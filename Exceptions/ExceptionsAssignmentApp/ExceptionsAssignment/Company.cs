namespace ExceptionsAssignment
{
    using ExceptionsAssignment.Contracts;
    using ExceptionsAssignment.Exceptions;

    public class Company
    {
        public Company()
        {
            this.Employees = new List<IEmployee>();
        }

        public void AddAssignment(TeamLead teamLead, CompanyEmployee companyEmployee, Assignment assignment)
        {
            if (CheckIfEmployeeIsAvailable(companyEmployee))
            {
                throw new TooManyAssignmentsException($"{companyEmployee.FirstName} can't take more assignments");
            }

            this.DistributeAsignments(teamLead, companyEmployee, assignment);
        }

        public List<IEmployee> Employees { get; set; }

        private void DistributeAsignments(IGiveAssignment teamLead, IGetAssignment employee, Assignment assignment)
        {
            teamLead.GiveAssignment(assignment, employee);
        }

        private bool CheckIfEmployeeIsAvailable(IAbleForMore employe)
        {
            return employe.IsAbleForMoreAssignments;
        }
    }
}
