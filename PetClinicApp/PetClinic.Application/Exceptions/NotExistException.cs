namespace PetClinic.Application.Exceptions
{
    public class NotExistException : Exception
    {
        public NotExistException(string message) 
            : base(message) { } 
    }
}
