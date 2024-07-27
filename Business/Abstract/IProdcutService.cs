using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Updata(Product product);
        IDataResult<Product> GetById(int id);
        IDataResult<Product> GetByName(string name);
        IDataResult<Product> GetByCategoryId(int id);
        IDataResult<List<Product>> GetAll();
    }
}
