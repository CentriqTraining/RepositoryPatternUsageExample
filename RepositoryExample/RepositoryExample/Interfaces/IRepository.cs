using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Find(int ID);
        bool Insert(T itemToAdd);
        bool Update(T itemToUpdate);
        bool Delete(T itemToDelete);
        bool Delete(int IDtoDelete);
    }
}
