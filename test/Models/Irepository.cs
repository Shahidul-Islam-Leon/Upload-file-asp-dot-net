using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models
{
    interface Irepository<T> where T:class
    {
      


         List<T> GetBooks();


         T Get(int id);


         void Insert(T entity);
        
    }
}
