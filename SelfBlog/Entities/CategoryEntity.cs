using System;
using System.Collections.Generic;

namespace SelfBlog.Entities
{
    public partial class CategoryEntity
    {
        public CategoryEntity()
        {
            Article = new HashSet<ArticleEntity>();
        }

        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Sequence { get; set; }
        public ICollection<ArticleEntity> Article { get; set; }
    }
}
