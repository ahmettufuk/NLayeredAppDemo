using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Nortwind.Entities.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool 
    {
        

        public static void Validate(IValidator validator,object model)
        {

            var context = new ValidationContext<object>(model);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
