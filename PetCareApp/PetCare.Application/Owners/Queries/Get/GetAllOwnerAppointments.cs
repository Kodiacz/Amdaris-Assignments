namespace PetCare.Application.Owners.Queries.Get
{
    public class GetAllOwnerAppointments : IRequest<List<Appointment>>
    {
        public int OwnerId { get; set; }
    }
}
