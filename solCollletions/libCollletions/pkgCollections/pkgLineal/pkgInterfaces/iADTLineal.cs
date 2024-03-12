using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iADTLineal<T> where T : IComparable<T>
    {
        #region CRUDs
        bool opModify(int prmIdx, T prmItem);
        bool opRetrieve(int prmIdx, T prmItem); 
        #endregion
        #region Query
        int opFind(T prmItem);
        bool opExist(T prmItem);
        bool opIstEmpty();
        bool opIsValid(int prmIdx);
        bool opItsOrderedAscending();
        bool opItsOrderedDescending(); 
        #endregion
        #region Getters
        int opGetLength();
        #endregion
        #region Serialize/DeSerialize
        T[] opToArray();
        string opToString();
        bool opToItems(T prmArray); 
        #endregion
    }
}
