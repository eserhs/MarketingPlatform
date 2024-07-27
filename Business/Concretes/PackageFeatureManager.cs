using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class PackageFeatureManager : IPackageFeatureService
    {
        IPackageFeatureDal _packageFeatureDal;

        public PackageFeatureManager(IPackageFeatureDal packageFeatureDal)
        {
            _packageFeatureDal = packageFeatureDal;
        }

        public IResult Add(PackageFeature packageFeature)
        {
            return new SuccessResult();
            _packageFeatureDal.Add(packageFeature);


         }

        public IResult Delete(PackageFeature packageFeature)

        {
            return new SuccessResult();
            _packageFeatureDal.Delete(packageFeature);
        }

        public IDataResult<List<PackageFeature>> GetAll()
        {
            return new SuccessDataResult<List<PackageFeature>>(_packageFeatureDal.GetAll());

        }

        public IDataResult<PackageFeature> GetByFeatureId(int featureId)
        {
            return new SuccessDataResult<PackageFeature>(_packageFeatureDal.Get(p=>p.FeatureId == featureId));

        }

        public IDataResult<PackageFeature> GetById(int id)
        {
            return new SuccessDataResult<PackageFeature>(_packageFeatureDal.Get(p=>p.Id == id));    
        }

        public IDataResult<PackageFeature> GetByPackageId(int packageId)
        {
            return new SuccessDataResult<PackageFeature>(_packageFeatureDal.Get(p => p.PackageId == packageId));
        }

        public IResult Update(PackageFeature packageFeature)
        {
            return new SuccessResult();
            _packageFeatureDal.UpDate(packageFeature);
             
        }
    }
}
