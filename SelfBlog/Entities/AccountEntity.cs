using System;
using System.Collections.Generic;

namespace SelfBlog.Entities
{
    public partial class AccountEntity
    {
        public AccountEntity()
        {
            Article = new HashSet<ArticleEntity>();
        }

        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }

        public ICollection<ArticleEntity> Article { get; set; }
    }
}
