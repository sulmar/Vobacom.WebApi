using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheeks.Interfaces
{
    public interface IService<TItem>
    {
        IList<TItem> Get();

        Task<IList<TItem>> GetAsync();

        TItem Get(int id);

        void Add(TItem item);

        Task AddAsync(TItem item);

        void Update(TItem item);

        void Delete(int id);
    }
}
