using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator() 
        {
            RuleFor(p => p.Date).NotEmpty();
            RuleFor(p => p.ImagePath).MinimumLength(2);
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CarId).GreaterThan(0);
         
        
        }

        
    }
    }
