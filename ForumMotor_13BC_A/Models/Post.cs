namespace ForumMotor_13BC_A.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TopicId { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int Like { get; set; }
        public int Dislike { get; set; }

        public int Reply { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual User User  { get; set; }
    }
}
