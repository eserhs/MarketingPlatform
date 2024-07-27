using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Database;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class PackageLevelDal : EfEntityRepositoryBase<PackageLevel, DB>, IPackageLevelDal
    {
        public List<PackageFeatureDto> GetByPackageDto(Expression<Func<PackageFeatureDto, bool>> filter = null)
        {
            using (var context = new DB())
            {
                var result = from packageFeatures in context.PackageFeatures
                             join packageLevels in context.PackageLevels on packageFeatures.PackageId equals packageLevels.Id
                             join featues in context.Features on packageFeatures.FeatureId equals featues.Id


                             select new PackageFeatureDto {
                                 PackageName = packageLevels.PackageName,
                                 PackagePrice = packageLevels.Price,
                                 PackageId = packageLevels.Id,
                                 FeatureName = featues.FeatureName,

                                 Decoupage = featues.Decoupage,
                                 Discount = featues.Discount,
                                 FormatBody = featues.FormatBody,
                                 ResolutionFormat = featues.ResolutionFormat,
                                 Setup = featues.Setup,
                                 ShootingEnvironment = featues.ShootingEnvironment,
                                 VideoShooting = featues.VideoShooting,
                                 ComplianceEnvironment = featues.ComplianceEnvironment,
                                 PhotoQuantity = featues.PhotoQuantity,
                                 
                               
                             
                             };

                return result.ToList();
            }
        }
    }
}
