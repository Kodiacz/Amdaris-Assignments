namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetSchedulesForAllDoctorsHandler : IRequestHandler<GetSchedulesForAllDoctors, List<Schedule>>
    {
        private readonly IUnitOfWork repo;

        public GetSchedulesForAllDoctorsHandler(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public Task<List<Schedule>> Handle(GetSchedulesForAllDoctors request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
