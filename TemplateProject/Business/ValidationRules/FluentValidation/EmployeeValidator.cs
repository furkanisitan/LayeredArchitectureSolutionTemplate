﻿using Business.ValidationRules.FluentValidation.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    class EmployeeValidator : BaseValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Salary).GreaterThan(0);
            RuleFor(x => x.Fullname).NotEmpty();
        }
    }
}
