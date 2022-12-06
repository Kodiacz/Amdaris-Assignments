namespace PetClinic.Application.Receptionists.Commands.Update
{
    public class UpdateReceptionistHandler : IRequestHandler<UpdateReceptionist, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public UpdateReceptionistHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(UpdateReceptionist request, CancellationToken cancellationToken)
        {
            Receptionist receptionist = new()
            {
                Id = request.Id,
                Age = request.Age,
                FirstName = request.FirstName,
                LastName = request.LastName,
                JobDescription = request.JobDescription,
                StartedJobDate = request.StartedJobDate,
                Phonenumber = request.Phonenumber,
            };

            await this.unitOfWorkRepo.ReceptionistRepository.UpdateAsync(receptionist);
            await this.unitOfWorkRepo.SaveAsync();

            return receptionist;
        }
    }
}
