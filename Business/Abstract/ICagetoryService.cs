using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategorySerivce
    {

        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);


        IDataResult<Category> Get(int id);
        IDataResult<List<Category>> GetAll();
    }
}
