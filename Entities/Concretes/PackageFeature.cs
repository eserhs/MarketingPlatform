using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class PackageFeature:IEntity

    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public int PackageId{ get; set; }

    }
}
