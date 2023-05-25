using PetCare.Domain.Entities;

namespace PetCare.Application.Doctors.Commands.Update
{
    public class UpdateDoctorScheduleHandler : IRequestHandler<UpdateDoctorSchedule, Schedule>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public UpdateDoctorScheduleHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Schedule> Handle(UpdateDoctorSchedule request, CancellationToken cancellationToken)
        {
            //TODO: Throw error if shcedule or doctor does not exist in the database!

            Schedule schedule = new()
            {
                Id = request.Id,
                Date = request.Date,
                IsAvailable = request.IsAvailable,
                DoctorId = request.DoctorId,
            };

            this.unitOfWorkRepo.DoctorRepository.UpdateDoctorSchedule(schedule);
            await this.unitOfWorkRepo.SaveAsync();

            return schedule;
        }
    }
}
