using System.Linq.Expressions;

namespace UTBEshop2.Domain.Repositories
{
    public interface IRepository <T, Tkey> // T je typ Entity (napr. Product) a TKey je typ kluca (napr. int) funguje pre vsetky entity
    {
        T? GetById(Tkey id); // najde zoznam podla id
        IEnumerable<T> GetAll(); //vsetky zaznamy
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate); // vsetky zaznamy s podmienkou
        void Add(T entity); //ostatok len pracuje so zaznamom
        void Edit(T entity);
        void Delete(T entity);
    }
}