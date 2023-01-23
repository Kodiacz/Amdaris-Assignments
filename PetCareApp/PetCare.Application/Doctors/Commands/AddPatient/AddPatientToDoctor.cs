namespace PetCare.Application.Doctors.Commands.AddPatient
{
    public class AddPatientToDoctor : IRequest<Pet>
    {
        public int PatientId { get; set; }

        public int DoctorId { get; set; }
    }
}
