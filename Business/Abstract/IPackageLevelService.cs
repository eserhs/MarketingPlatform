using Core.Utilites.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPackageLevelService
    {
        IResult Add(PackageLevel packageLevel);
        IResult Remove(PackageLevel packageLevel);
        IResult Update(PackageLevel packageLevel);

        IDataResult<List<PackageLevel>> GetAll();
        IDataResult<PackageLevel> GetById(int id);
        IDataResult<PackageLevel> GetByName(string name);


        IDataResult<List<PackageFeatureDto>> GetByPackageDto();

    }
}
