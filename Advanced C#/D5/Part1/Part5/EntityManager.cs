using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class EntityManager <T> where T: BaseModel
    {
        DatabaseStorage db;
        DbSet<T> Set;
        public EntityManager(DatabaseStorage _db)
        {
            db = _db;
            Set = db.Set<T>();
        }
        public void Add(T entity)
        {
            Set.Add(entity);
            db.SaveChanges();
        }
        public void Delete(T entity)
        {
            Set.Remove(entity);
        }
        public List<T> GetAll()
        {
            return Set.ToList();
        }
        public T Get(int id)
        {
            return Set.FirstOrDefault(i => i.ID == id);
        }
    }
}
