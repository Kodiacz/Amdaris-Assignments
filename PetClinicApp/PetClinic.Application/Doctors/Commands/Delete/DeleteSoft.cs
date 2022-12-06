namespace PetClinic.Application.Doctors.Commands.Delete
{
    public class DeleteSoft : IRequest<Doctor>
    {
        public int Id { get; set; }
    }
}
