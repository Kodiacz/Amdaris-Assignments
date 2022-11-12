using ExceptionsAssignment.Contracts;

namespace ExceptionsAssignment
{
    //Exception idea for => No employe availbe for this task
    public class Company
    {
        public Company()
        {
            this.Employees = new List<IEmployee>();
        }

        public void AddAssignment(string firstName, string lastName)
        {
            var employee = this.Employees
                .FirstOrDefault((fn) => (fn.FirstName == firstName) && (fn.LastName == lastName));

            if ()
        }

        public List<IEmployee> Employees { get; set; }

        private void DistributeAsignments(IGiveAssignment teamLead, IGetAssignment employee, Assignment assignment)
        {
            teamLead.GiveAssignment(assignment, employee);
        }
    }
}
