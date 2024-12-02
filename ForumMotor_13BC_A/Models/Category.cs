﻿namespace ForumMotor_13BC_A.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
        public virtual User User { get; set; }
    }
}
