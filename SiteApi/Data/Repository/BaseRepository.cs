using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> where T : BaseModel
    {
        public void Create(T model)
        {
            using (var context = new RepContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            using (var context = new RepContext())
            {
                return context.Set<T>().ToList();
            }
        }
        public T Read(int id)
        {
            using (var context = new RepContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        public void Update(T model)
        {
            using (var context = new RepContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new RepContext())
            {
                context.Entry<T>(Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
