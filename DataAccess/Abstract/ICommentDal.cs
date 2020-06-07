using Core.Abstract.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICommentDal : IRepository<Comment>
    {
    }
}
