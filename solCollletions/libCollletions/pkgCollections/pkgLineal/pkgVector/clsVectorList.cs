using System;
using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT;
using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;


namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorList<T> : clsADTVector<T>, iList<T> where T : IComparable<T>
    {
        #region CRUDs
        public bool opAdd(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opInsert(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        } 
        #endregion
        #region Builders
        public clsVectorList(int capacity)
        {
            throw new NotImplementedException();
        }
        public clsVectorList()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
