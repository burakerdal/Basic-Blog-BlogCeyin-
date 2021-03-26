using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogCeyinSite.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime SubmitTime { get; set; }
        public bool Confirm { get; set; }
        public bool PublishHome { get; set; }

        public string Author { get; set; }
    }
}