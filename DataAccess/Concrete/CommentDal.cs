using Core.Abstract.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class CommentDal : RepositoryBase<Comment, ProjectContext>, ICommentDal
    {
    }
}
