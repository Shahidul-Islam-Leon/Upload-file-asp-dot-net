using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Repository<T> : Irepository<T> where T : class
    {

        BookDb context = new BookDb();
        public T Get(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public List<T> GetBooks()
        {
            return this.context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            this.context.Set<T>().Add(entity);
            this.context.SaveChanges();
        }
    }
}