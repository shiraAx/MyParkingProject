using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Interfaces
{
    public interface IServices<T>
    {
        Task<T> Add(T model);
        Task<T> Update(T model);
        Task Delete(int key);
        Task<T> GetById(int key);
        Task<List<T>> GetAll();
    }
}
