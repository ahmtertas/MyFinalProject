using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //class --> referans tip olarabilir.
    //new()---> newlenebilir olmalı 
    //IEntity --> IEntity olabilir, product,category,customer'ın ortak özelliğidir bu classlar olabilir.
    public interface IEntityRepository<T> 
        where T : class, IEntity, new() 
    {
        //Tüm listeyi getiriyoruz.
        //filter = null--> filtre vermesende olur anlamına gelmekteedir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //Örneğin bankacılık uygulumasında tek bir bankanın verilerini getirmek için Get yapısını kullanabiliriz.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
