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

        TItem Get(int id);

        void Add(TItem item);

        void Update(TItem item);

        void Delete(int id);
    }
}
