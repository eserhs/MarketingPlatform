using Core.DataAccess.Abstrats.Core.DataAccess;
using DataAccess.Concretes;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPackageLevelDal:IEntityRepository<PackageLevel>
    {
        List<PackageFeatureDto> GetByPackageDto(Expression<Func<PackageFeatureDto, bool>> filter = null);
    }
}
