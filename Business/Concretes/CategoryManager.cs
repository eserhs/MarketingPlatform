using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Asprcts.Autofac.Caching;
using Core.Asprcts.Autofac.Performance;
using Core.Asprcts.Autofac.Validatoin;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class CategoryManager : ICategorySerivce
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        [PerformanceAspect(5)]
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidation))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Category category)
        {
            return new SuccessResult(Messages.CategoryAdded);
            _categoryDal.Add(category);

        }

        public IResult Delete(Category category)
        {
            return new SuccessResult(Messages.CategoryDeleted);
            _categoryDal.Delete(category);
        }

        [PerformanceAspect(5)]
        [CacheRemoveAspect("IProductService.Get")]
        public IDataResult<Category> Get(int id)
        {
           return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == id),Messages.CategoryGetById);   
        }

        [PerformanceAspect(5)]
        [CacheRemoveAspect("IProductService.Get")]
        public IDataResult<List<Category>> GetAll()
        {
           return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.CategoryGetAll);
        }

        public IResult Update(Category category)
        {
            return new SuccessResult(Messages.CategoryUpdated);
            _categoryDal.UpDate(category);
        }
    }
}
