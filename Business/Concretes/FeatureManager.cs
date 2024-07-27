using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public IResult Add(Feature feature)
        {
            return new SuccessResult();
            _featureDal.Add(feature);
         }

        public IResult Delete(Feature feature)
        {
            return new SuccessResult();
            _featureDal.Delete(feature);

        }

        public IDataResult<List<Feature>> GetAll()
        {
            return new SuccessDataResult<List<Feature>>(_featureDal.GetAll());
        }

        public IDataResult<Feature> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Feature> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(Feature feature)
        {
            throw new NotImplementedException();
        }
    }
}
