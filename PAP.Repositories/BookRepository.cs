using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAP.DataAccess;

namespace PAP.Repositories
{
    public class BookRepository : RepositoryBase<Book>
    {
        public void AddMany(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Add(book);
            }
        }
    }
}