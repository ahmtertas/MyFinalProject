using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //Validator constructor'ın içine yazılır.
        public ProductValidator()
        {
            //kurallarımızı yazdık bu kısma
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            //ürün fiyatı 0'dan büyük
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //ürün fiyatı 10'dan büyük olacak--CategoryId=1 olanlar açısından.
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId == 1);
            //Kendi kuralımızı yazıyoruz
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
            //C# içindeki steam fonksiyonu-->'arg'
            //A ile başlıyorusa true döndürüyor.
            return arg.StartsWith("A");
        }
    }
}
