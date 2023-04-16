namespace PetCare.Domain.Entities
{
    public class UsersRoles
    {
        public int UserId { get; set; }
        public Owner User { get; set; }

        public int RoleId { get; set; }
    }
}
