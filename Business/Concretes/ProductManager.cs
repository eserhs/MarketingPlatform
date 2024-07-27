using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Asprcts.Autofac.Caching;
using Core.Asprcts.Autofac.Performance;
using Core.Asprcts.Autofac.Transaction;
using Core.Asprcts.Autofac.Validatoin;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Concretes
{
    internal class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
      //  [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidation))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
            return new SuccessResult(Messages.ProductAdded);
            _productDal.Add(product);

        }
        [ValidationAspect(typeof(ProductValidation))]
        public IResult Delete(Product product)
        {
            return new SuccessResult(Messages.ProductDeleted);
            _productDal.Add(product);
        }


        [CacheAspect]

        [ValidationAspect(typeof(ProductValidation))]
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductGetAll);

        }
        [ValidationAspect(typeof(ProductValidation))]
        public IDataResult<Product> GetByCategoryId(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.CategoryId == id));
        }
        [ValidationAspect(typeof(ProductValidation))]
        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
        }
        [ValidationAspect(typeof(ProductValidation))]
        public IDataResult<Product> GetByName(string name)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductName == name));
        }
        [CacheRemoveAspect("IProductService.Get")]
        [ValidationAspect(typeof(ProductValidation))]
        public IResult Updata(Product product)
        {
            return new SuccessResult(Messages.ProductUpdated);
            _productDal.UpDate(product);
         }
    }
}
