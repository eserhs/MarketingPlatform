using Core.DataAccess.Abstrats.Core.DataAccess;
using Core.Entities.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<Core.Entities.Concretes.User>
    {
        List<OperationClaim> GetClaims (User user);
    }
}
