using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //IResult ile implementasyonu yapmak zorunda değiliz 
    //interfaceler kendi aralında implemente edilmedende çalışır inherite mantığı gibi
    public interface IDataResult<T> : IResult
    {
        //
        T Data { get; }
    }
}
