using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iList<T> where T : IComparable<T>
    {
        #region CRUDs
        bool opAdd(T prmItem);
        bool opInsert(int prmIdx, T prmItem);
        bool opRemove(int prmIdx, T prmItem); 
        #endregion
    }
}
