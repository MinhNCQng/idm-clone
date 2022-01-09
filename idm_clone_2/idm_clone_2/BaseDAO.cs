using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idm_clone_2
{
    interface BaseDAO<T>
    {
        void add(T t);
        void delete(int index);

    }
}
