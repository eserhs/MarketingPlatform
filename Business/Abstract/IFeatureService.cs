using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFeatureService
    {
        IResult Add(Feature feature);
        IResult Delete(Feature feature);
        IResult Uptade(Feature feature);

        IDataResult<List<Feature>> GetAll();
        IDataResult<Feature> GetById(int id);
        IDataResult<Feature> GetByName(string name);
           


    }
}
