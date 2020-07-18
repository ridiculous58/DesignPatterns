using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Urun ismi bos olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerunit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short) 0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryId==2);

            RuleFor(p => p.ProductName).Must(StartwithA);//kendi kuralmızı yazabiliriz

        }

        private bool StartwithA(string arg)
        {
            return arg.StartsWith("A") && arg.StartsWith("a");
        }
    }
}
