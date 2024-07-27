using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entities.DTOs
{
    public class PackageFeatureDto:IDto
    {
        public string PackageName { get; set; }
        public decimal PackagePrice { get; set; }
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
        public int PackageId { get; set; }

    }
}
