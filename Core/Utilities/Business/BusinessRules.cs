using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    //bu class aslında bir araç Run metodunu static çalıştırıyoruz burada interface olmamalı
    public class BusinessRules
    {
        //logics-->iş kuralı demektir.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
