using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Database;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class ProductImageDal:EfEntityRepositoryBase<ProductImage,DB>,IProductImageDal 
    {
    }
}
