using Core.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    [Keyless]
    public class ProductImage:IEntity
    {
        
        public int ImageId { get; set; }    
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

    }
}
