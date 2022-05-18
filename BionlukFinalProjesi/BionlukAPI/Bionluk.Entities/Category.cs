namespace Bionluk.Entities
{
    public class Category :IEntity
    {
        public int CategoryId { get; set; }
        public String Profession { get; set; }

        public ICollection<User> Users { get; set; }
    }
}