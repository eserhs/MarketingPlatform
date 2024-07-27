using Core.Entities.Abstracts;
using Microsoft.AspNetCore.Http.Features.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class PackageLevel:IEntity
    {
        public int Id { get; set; }
        

        public string PackageName{ get; set; }

        public decimal Price { get; set; }
    }
}
