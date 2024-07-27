using Core.Utilites.Results;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IResult Add(IFormFile file, ProductImage prodcutImage);
        IResult Delete(ProductImage prodcutImage);
        IResult Update(IFormFile file, ProductImage prodcutImage);

        IDataResult<List<ProductImage>> GetAll();
        IDataResult<List<ProductImage>> GetByCarId(int productId);
        IDataResult<ProductImage> GetByImageId(int imageId);
    }
}
