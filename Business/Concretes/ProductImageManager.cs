using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.Constants.ImagePath;
using Core.Utilites.Helpers;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class ProductImageManager : IProductImageService
    {
        IProductImageDal _productImageDal;
        IFileHelper _fileHelper;

        public ProductImageManager(IProductImageDal productImageDal ,IFileHelper fileHelper)
        {
            _productImageDal = productImageDal;
            _fileHelper = fileHelper;
        }

        [SecuredOperation("product.add,admin")]

        public IResult Add(IFormFile file, ProductImage prodcutImage)
        {
            prodcutImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            prodcutImage.Date = DateTime.Now;
            return new SuccessResult(Messages.SuccessUplodImage);
        }

        public IResult Delete(ProductImage prodcutImage)
        {

            _fileHelper.Delete(PathConstants.ImagesPath + prodcutImage.ImagePath);
            _productImageDal.Delete(prodcutImage);
            return new SuccessResult();
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<List<ProductImage>> GetByCarId(int productId)
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll(p => p.ProductId == productId));
        }

        public IDataResult<ProductImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(p => p.ImageId == imageId));
        }

        public IResult Update(IFormFile file, ProductImage prodcutImage)
        {
            prodcutImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + prodcutImage.ImagePath, PathConstants.ImagesPath);
            _productImageDal.UpDate(prodcutImage);
            return new SuccessResult();
        }
    }
}
