using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Category:IEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
    }
}
