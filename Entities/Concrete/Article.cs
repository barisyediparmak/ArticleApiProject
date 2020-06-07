using Core.Abstract.Interfaces;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Article : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
