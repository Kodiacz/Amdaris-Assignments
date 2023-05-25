namespace PetCare.Domain.Entities
{
    public class Role
    {
        public Role()
        {
            this.UsersRoles = new HashSet<UsersRoles>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public ICollection<UsersRoles> UsersRoles { get; set; } = null!;
    }
}
