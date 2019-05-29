using FluentValidation;
using FluentValidationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationMVC.Validation
{
    public class ValidatorFactory : ValidatorFactoryBase
    {
        private static Dictionary<Type, IValidator> validators = new Dictionary<Type, IValidator>();

        static ValidatorFactory()
        {
            validators.Add(typeof(IValidator<UserViewModel>), new UserViewModelValidator());
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator;
            if (validators.TryGetValue(validatorType, out validator))
            {
                return validator;
            }
            return validator;
        }
    }

}