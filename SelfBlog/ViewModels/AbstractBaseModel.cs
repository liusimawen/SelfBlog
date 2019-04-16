using System;
using System.Collections.Generic;
using System.Text;

namespace SelfBlog.ViewModels
{
    /// <summary>
    /// 绑定视图VM基类
    /// </summary>
    public abstract class AbstractBaseModel
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
