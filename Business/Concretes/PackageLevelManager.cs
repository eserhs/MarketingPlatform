using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class PackageLevelManager : IPackageLevelService
    {
        IPackageLevelDal _packageLevelDal;

        public PackageLevelManager(IPackageLevelDal packageLevelDal)
        {
            _packageLevelDal = packageLevelDal;
        }

        public IResult Add(PackageLevel packageLevel)
        {
            return new SuccessResult();
            _packageLevelDal.Add(packageLevel);
        }

        public IDataResult<PackageLevel> GetById(int id)
        {
            return new SuccessDataResult<PackageLevel>(_packageLevelDal.Get(p => p.Id== id)) ;
        }

        public IDataResult<List<PackageLevel>> GetAll()
        {
            return new SuccessDataResult<List<PackageLevel>>(_packageLevelDal.GetAll());
        }

        public IDataResult<PackageLevel> GetByName(string name)
        {
            return new SuccessDataResult<PackageLevel>(_packageLevelDal.Get(p => p.PackageName == name));
        }

        public IResult Remove(PackageLevel packageLevel)
        {
            return new SuccessResult();
            ;_packageLevelDal.Delete(packageLevel);
        }

        public IResult Update(PackageLevel packageLevel)
        {
            return new SuccessResult();
            _packageLevelDal.UpDate(packageLevel);
        }

        public IDataResult<List<PackageFeatureDto>> GetByPackageDto()
        {
            return new SuccessDataResult<List<PackageFeatureDto>>(_packageLevelDal.GetByPackageDto());
        }
    }
}
