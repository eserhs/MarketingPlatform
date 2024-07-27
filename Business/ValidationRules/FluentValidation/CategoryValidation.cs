using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidation: AbstractValidator<Category>
    {
        public CategoryValidation() {


            
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(2);

        }


    }
}
