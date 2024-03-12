using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T> : iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        int attLength = 0;
        bool attItsOrderedDescending = false;
        bool attItsOrderedAscending = false; 
        #endregion
        #region Operations
        #region CRUDs
        public bool opModify(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRetrieve(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Query
        public int opFind(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opExist(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opIstEmpty()
        {
            throw new NotImplementedException();
        }
        public bool opIsValid(int prmIdx)
        {
            throw new NotImplementedException();
        }
        public bool opItsOrderedAscending()
        {
            throw new NotImplementedException();
        }
        public bool opItsOrderedDescending()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Getters
        public int opGetLength()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Serialize/DeSerialize
        public T[] opToArray()
        {
            throw new NotImplementedException();
        }
        public string opToString()
        {
            throw new NotImplementedException();
        }
        public bool opToItems(T prmArray)
        {
            throw new NotImplementedException();

        }
        #endregion 
        #endregion
        
    }
}
