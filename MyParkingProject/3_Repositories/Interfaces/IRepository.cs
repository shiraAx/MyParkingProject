using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Add(T model);
        Task<T> Update(T model);
        Task Delete(int key);
        Task<T> GetById(int key);
        Task<List<T>> GetAll();
    }
}
