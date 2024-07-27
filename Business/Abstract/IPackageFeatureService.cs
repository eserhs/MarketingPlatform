using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPackageFeatureService
    {
        IResult Add(PackageFeature packageFeature);
        IResult Delete(PackageFeature packageFeature);
        IResult Update(PackageFeature packageFeature);

        IDataResult<List<PackageFeature>> GetAll();
        IDataResult<PackageFeature> GetById(int id);
        IDataResult<PackageFeature> GetByPackageId(int packageId);
        IDataResult<PackageFeature> GetByFeatureId(int featureId);

    }
}
