using Core.Abstract.Interfaces;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Comment : BaseEntity, IEntity
    {
        public string Content { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
