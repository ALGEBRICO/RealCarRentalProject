using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<Core.Entities.Concrete.User>
    {
        List<OperationClaim> GetClaims(Core.Entities.Concrete.User user);
    }
}