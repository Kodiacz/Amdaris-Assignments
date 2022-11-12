namespace ExceptionsAssignment.Exceptions
{
    public class TooManyAssignmentsException : Exception
    {
        public TooManyAssignmentsException(string massage)
        : base(massage) { }
    }
}
