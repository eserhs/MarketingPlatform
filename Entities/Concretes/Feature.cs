using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Feature:IEntity
    {
        public int Id { get; set; }
        public string FeatureName { get; set; }
        public int PhotoQuantity { get; set; }
        public bool VideoShooting { get; set; }
        public bool Decoupage { get; set; }
        public int Discount { get; set; }
        public string ResolutionFormat { get; set; }
        public string FormatBody { get; set; }
        public string ComplianceEnvironment { get; set; }
        public string ShootingEnvironment { get; set; }
        public string Setup { get; set; }


    }
}
