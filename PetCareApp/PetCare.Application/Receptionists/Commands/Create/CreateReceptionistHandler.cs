namespace PetCare.Application.Receptionists.Commands.Create
{
    public class CreateReceptionistHandler : IRequestHandler<CreateReceptionist, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public CreateReceptionistHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(CreateReceptionist request, CancellationToken cancellationToken)
        {
            Receptionist receptionist = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Phonenumber = request.Phonenumber,
                JobDescription = request.JobDescription,
                StartedJobDate = request.StartedJobDate,
            };

            await this.unitOfWorkRepo.ReceptionistRepository.AddAsync(receptionist);
            await this.unitOfWorkRepo.SaveAsync();

            return receptionist;
        }
    }
}
