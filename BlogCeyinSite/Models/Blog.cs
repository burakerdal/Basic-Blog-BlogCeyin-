using System;

namespace BlogCeyinSite.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime SubmitTime { get; set; }
        public bool Confirm { get; set; }
        public bool PublishHome { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Author { get; set; }

    }
}