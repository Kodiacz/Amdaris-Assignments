using MediatR;

namespace PetClinic.Doctors.Commands.CreateDoctor
{
    public class CreateDocrotHandler : IRequestHandler<CreateDoctorCommand, int>
    {
        public Task<int> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
