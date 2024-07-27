using Core.DataAccess.Abstrats.Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IFeatureDal:IEntityRepository<Feature>
    {
    }
}
