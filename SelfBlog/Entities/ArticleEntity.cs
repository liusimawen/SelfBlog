using System;
using System.Collections.Generic;

namespace SelfBlog.Entities
{
    public partial class ArticleEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public AccountEntity Account { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
