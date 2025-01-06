using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Repositories
{
    public interface IRepository<T> where T:class
    {
        DbSet<T> GetAll();

        IEnumerable<T> GetByid(int id);
        Task<bool> Post(T entity);
        Task<bool> Put(int id, T entity);
        Task<bool> Delete(int id);
    }
   
}
