namespace PetClinic.Application.Exceptions
{
    public class AlreadyDeletedException : Exception
    {
        public AlreadyDeletedException(string message)
            : base(message) { }
    }
}
