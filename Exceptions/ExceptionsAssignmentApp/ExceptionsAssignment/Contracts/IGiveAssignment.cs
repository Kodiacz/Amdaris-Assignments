namespace ExceptionsAssignment.Contracts
{
    public interface IGiveAssignment
    {
        void GiveAssignment(Assignment assignment, IGetAssignment employee);
    }
}
