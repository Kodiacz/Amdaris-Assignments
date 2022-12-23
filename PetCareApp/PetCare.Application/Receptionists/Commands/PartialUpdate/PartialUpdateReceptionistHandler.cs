namespace PetCare.Application.Receptionists.Commands.PartialUpdate
{
    public class PartialUpdateReceptionistHandler : IRequestHandler<PartialUpdateReceptionist, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public PartialUpdateReceptionistHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(PartialUpdateReceptionist request, CancellationToken cancellationToken)
        {
            Receptionist owner = new Receptionist
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Phonenumber = request.Phonenumber,
            };

            await this.unitOfWorkRepo.ReceptionistRepository.UpdateAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
