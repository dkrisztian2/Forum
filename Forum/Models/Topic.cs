namespace Forum.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CategoryId { get; set; }
        public virtual string ForumUserId { get; set; }

        public virtual ForumUser User { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
