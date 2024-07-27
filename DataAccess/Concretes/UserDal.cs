using Core.DataAccess.EntityFrameWork;
using Core.Entities.Concretes;
using DataAccess.Abstract;
using DataAccess.Database;
using Entities.Concretes;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concretes
{
    public class UserDal: EfEntityRepositoryBase<User,DB>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new  DB())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
