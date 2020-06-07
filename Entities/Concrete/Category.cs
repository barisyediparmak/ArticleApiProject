using Core.Abstract.Interfaces;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
