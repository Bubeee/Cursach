namespace Coursach.Entities
{
    public class Mark
    {
        public bool IsPassed { get; set; }

        public User User { get; set; }

        public Subject Subject { get; set; }
    }
}