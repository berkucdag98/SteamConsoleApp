using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Abstract
{
    public interface ISaveService<T> where T : class
    {
        T Add(T entity);

        T Update(T entity);

        T Delete(T entity);
    }
}
