using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilites.Helpers;
using Core.Utilites.Interceptars;
using Core.Utilites.Security.JWT;
using Core.Utilities.Helpers;
using DataAccess.Abstract;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<ProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategorySerivce>().SingleInstance();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>().SingleInstance();


            builder.RegisterType<ProductImageManager>().As<IProductImageService>().SingleInstance();
            builder.RegisterType<ProductImageDal>().As<IProductImageDal>().SingleInstance();

            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<UserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            builder.RegisterType<PackageFeatureManager>().As<IPackageFeatureService>().SingleInstance();
            builder.RegisterType<FeatureManager>().As<IFeatureService>().SingleInstance();
            builder.RegisterType<PackageLevelManager>().As<IPackageLevelService>().SingleInstance();

            builder.RegisterType<PackageFeatureDal>().As<IPackageFeatureDal>().SingleInstance();
            builder.RegisterType<FeatureDal>().As<IFeatureDal>().SingleInstance();
            builder.RegisterType<PackageLevelDal>().As<IPackageLevelDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();



        }
    }
}

