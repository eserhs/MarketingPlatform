using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    internal class ProductValidation: AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(p => p.ProductName ).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
           
        }
    }
}
