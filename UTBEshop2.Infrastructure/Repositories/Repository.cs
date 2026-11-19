using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UTBEshop2.Domain.Repositories;

namespace UTBEshop2.Infrastructure.Repositories
{
    public class Repository<T, TKey> : IRepository<T, TKey> where T : class // ": IRepository<T, TKey>" = trieda plní zmluvu z Domain (musí mať všetky jej metódy)
    {
        private readonly DbSet<T> dbSet;   // jedna tabuľka (pre Product = tabuľka produktov)
        private readonly DbContext dbContext; // celá databáza (kvôli SaveChanges)

        public Repository(DbContext dbContext) //konstruktor nastavi pozadovane polia
        {
            this.dbSet = dbContext.Set<T>(); 
            this.dbContext = dbContext;
        }
        
        // ========= Citanie 
        public virtual T GetById(TKey id) //vrat zaznamy podla id
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll() // vrat vsetky zaznamy
        {
            return dbSet.ToList();
        }
        
        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate) // vrat zaznamy ktore splnaju podmienku
        {
            return dbSet.Where(predicate).ToList(); // SQL: SELECT ... WHERE Price > 10
        }
        
        // ======== Zapis
        
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);                
            dbContext.SaveChanges();              // ulozi zmeny
        }
        
        public virtual void Edit(T entity)
        {
            dbSet.Update(entity);                 
            dbContext.SaveChanges();              
        }
        
        // ======== Zmaz
        
        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);                 // poznač: "zmazať"
            dbContext.SaveChanges();              // SQL: DELETE FROM ... WHERE Id = ...
        }
    }
}