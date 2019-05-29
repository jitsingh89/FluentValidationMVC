using FluentValidation;
using FluentValidationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationMVC.Validation
{
    public class UserViewModelValidator : AbstractValidator<UserViewModel>
    {
        public UserViewModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("*Name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("*Password is required").Length(6, 10);
            RuleFor(x => x.Email).EmailAddress().WithMessage("Not a valid email id.").NotEmpty().WithMessage("*Email is is required");
        }
    }
}