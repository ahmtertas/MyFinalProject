using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        //başarılı mı başarısız mı-Yapmaya çalışılan ekleme işi-
        bool Success { get; }
        //başarılı ise ürün eklendi, başrarısız şundan dolayı şeklinde bilgilendirme
        string Message { get; }
    }
}
