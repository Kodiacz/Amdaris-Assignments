namespace PetCare.Domain.Entities
{
    public class UsersRoles
    {
        public int UserId { get; set; }
        public Owner User { get; set; } = null!;

        public int RoleId { get; set; }
    }
}
